using GeoIntegral.Controller;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Usuario_Terrenos : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private TerrenoController terrenoController = new TerrenoController();
        private bool calculado = false;
        private bool glIniciado = false;

        // datos de la grilla para OpenGL
        private List<(float x, float y, float z, float t)> celdas = new List<(float, float, float, float)>();
        private List<(float x, float y, float z)> puntosGL = new List<(float, float, float)>();
        private float glXMin, glXMax, glYMin, glYMax, glZMin, glZMax;

        // rotacion con mouse
        private float rotX = 30f, rotY = -45f;
        private Point mouseUltimo;
        private bool arrastrando = false;

        public Usuario_Terrenos(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;

            dgvPuntos.AllowUserToAddRows = false;
            dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuntos.ReadOnly = true;

            lblMensaje_Proyecto.ForeColor = Color.Red;
            lblMensaje_Proyecto.Visible = false;
            lblMensaje_Coordenadas.ForeColor = Color.Red;
            lblMensaje_Coordenadas.Visible = false;
            lblArea.Text = "Área: --";
            lblVolumen.Text = "Volumen: --";

            btnAgregarPunto.Click += btnAgregarPunto_Click;
            btnEliminarPunto.Click += btnEliminarPunto_Click;
            btnLimpiarPuntos.Click += btnLimpiarPuntos_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnGuardar.Click += btnGuardar_Click;
           
            CargarProyectosGuardados();

            glControl.Load += GlControl_Load;
            glControl.Paint += GlControl_Paint;
            glControl.Resize += GlControl_Resize;
            glControl.MouseDown += GlControl_MouseDown;
            glControl.MouseMove += GlControl_MouseMove;
            glControl.MouseUp += GlControl_MouseUp;
        }

        // ── OPENGL EVENTOS ───────────────────────────────────────

        private void GlControl_Load(object sender, EventArgs e)
        {
            glIniciado = true;
            GL.ClearColor(0.08f, 0.08f, 0.18f, 1f);
            GL.Enable(EnableCap.DepthTest);
            ConfigurarProyeccion();
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            if (!glIniciado) return;
            ConfigurarProyeccion();
        }

        private void ConfigurarProyeccion()
        {
            glControl.MakeCurrent();
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            float aspect = (float)glControl.Width / glControl.Height;
            Matrix4 persp = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f), aspect, 0.1f, 1000f);
            GL.LoadMatrix(ref persp);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        private void GlControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (!glIniciado) return;
            glControl.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            // camara alejada
            GL.Translate(0f, 0f, -3f);
            GL.Rotate(rotX, 1f, 0f, 0f);
            GL.Rotate(rotY, 0f, 0f, 1f);

            if (celdas.Count > 0)
                DibujarSuperficie();
            else
                DibujarEjes();

            glControl.SwapBuffers();
        }

        private void DibujarEjes()
        {
            // ejes en la esquina inferior izquierda de la superficie
            float orig = -0.5f;
            float len = 0.5f;

            GL.LineWidth(2f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 0.3f, 0.3f); GL.Vertex3(orig, orig, orig); GL.Vertex3(orig + len, orig, orig); // X rojo
            GL.Color3(0.3f, 1f, 0.3f); GL.Vertex3(orig, orig, orig); GL.Vertex3(orig, orig + len, orig); // Y verde
            GL.Color3(0.3f, 0.5f, 1f); GL.Vertex3(orig, orig, orig); GL.Vertex3(orig, orig, orig + len); // Z azul
            GL.End();
        }

        private void DibujarSuperficie()
        {
            // 1 — superficie rellena con iluminación suave
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.Begin(PrimitiveType.Quads);
            foreach (var c in celdas)
            {
                float t = c.t;
                float r = t > 0.5f ? (t - 0.5f) * 2f : 0f;
                float g = t < 0.5f ? t * 2f : (1f - t) * 2f;
                float b = t < 0.5f ? 1f - t * 2f : 0f;
                GL.Color3(r, g, b);
                GL.Vertex3(c.x, c.y, c.z);
            }
            GL.End();

            // 2 — malla encima con transparencia para dar efecto de rejilla
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.LineWidth(0.4f);
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0f, 0f, 0f);
            foreach (var c in celdas)
                GL.Vertex3(c.x, c.y, c.z);
            GL.End();

            // restaurar modo fill
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            // 3 — puntos originales sobre la superficie
            GL.PointSize(10f);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(1f, 1f, 0f);
            foreach (var p in puntosGL)
                GL.Vertex3(p.x, p.y, p.z);
            GL.End();

            // 4 — ejes en esquina
            DibujarEjes();
        }

        // ── MOUSE ROTACIÓN ───────────────────────────────────────

        private void GlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                mouseUltimo = e.Location;
            }
        }

        private void GlControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!arrastrando) return;
            float dx = e.X - mouseUltimo.X;
            float dy = e.Y - mouseUltimo.Y;
            rotY += dx * 0.5f;
            rotX += dy * 0.5f;
            mouseUltimo = e.Location;
            glControl.Invalidate();
        }

        private void GlControl_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        // ── PREPARAR DATOS PARA OpenGL ───────────────────────────

        private void PrepararDatosGL()
        {
            var puntos = terrenoController.ObtenerPuntos();
            if (puntos.Count == 0) return;

            glXMin = (float)puntos[0].X; glXMax = glXMin;
            glYMin = (float)puntos[0].Y; glYMax = glYMin;
            glZMin = (float)puntos[0].Z; glZMax = glZMin;

            foreach (var p in puntos)
            {
                if ((float)p.X < glXMin) glXMin = (float)p.X;
                if ((float)p.X > glXMax) glXMax = (float)p.X;
                if ((float)p.Y < glYMin) glYMin = (float)p.Y;
                if ((float)p.Y > glYMax) glYMax = (float)p.Y;
                if ((float)p.Z < glZMin) glZMin = (float)p.Z;
                if ((float)p.Z > glZMax) glZMax = (float)p.Z;
            }

            float rx = glXMax - glXMin == 0 ? 1 : glXMax - glXMin;
            float ry = glYMax - glYMin == 0 ? 1 : glYMax - glYMin;
            float rz = glZMax - glZMin == 0 ? 1 : glZMax - glZMin;

            // puntos normalizados entre -0.5 y 0.5
            puntosGL.Clear();
            foreach (var p in puntos)
                puntosGL.Add((
                    ((float)p.X - glXMin) / rx - 0.5f,
                    ((float)p.Y - glYMin) / ry - 0.5f,
                    ((float)p.Z - glZMin) / rz - 0.5f
                ));

            // cuadrícula de celdas Riemann (misma que el cálculo)
            celdas.Clear();
            int n = 30;
            float dx = (glXMax - glXMin) / n;
            float dy = (glYMax - glYMin) / n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    float x0 = glXMin + i * dx;
                    float y0 = glYMin + j * dy;
                    float x1 = x0 + dx;
                    float y1 = y0 + dy;
                    float xc = (x0 + x1) / 2f;
                    float yc = (y0 + y1) / 2f;
                    float zc = (float)terrenoController.ObtenerZPublico(xc, yc);
                    float t = rz == 0 ? 0.5f : (zc - glZMin) / rz;

                    // 4 vértices del quad normalizados
                    float nx0 = (x0 - glXMin) / rx - 0.5f;
                    float nx1 = (x1 - glXMin) / rx - 0.5f;
                    float ny0 = (y0 - glYMin) / ry - 0.5f;
                    float ny1 = (y1 - glYMin) / ry - 0.5f;
                    float nz = (zc - glZMin) / rz - 0.5f;

                    // agrego 4 vértices del quad (un quad = 4 entradas)
                    celdas.Add((nx0, ny0, nz, t));
                    celdas.Add((nx1, ny0, nz, t));
                    celdas.Add((nx1, ny1, nz, t));
                    celdas.Add((nx0, ny1, nz, t));
                }
            }
        }

        // ── BOTONES ──────────────────────────────────────────────

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            lblMensaje_Coordenadas.Visible = false;

            if (txtX.Text.Trim() == "" || txtY.Text.Trim() == "" || txtZ.Text.Trim() == "")
            {
                lblMensaje_Coordenadas.Text = "Complete los tres campos X, Y, Z*";
                lblMensaje_Coordenadas.Visible = true;
                return;
            }

            if (!double.TryParse(txtX.Text, out double x) ||
                !double.TryParse(txtY.Text, out double y) ||
                !double.TryParse(txtZ.Text, out double z))
            {
                lblMensaje_Coordenadas.Text = "Solo se permiten valores numéricos*";
                lblMensaje_Coordenadas.Visible = true;
                return;
            }

            terrenoController.AgregarPunto(x, y, z);
            dgvPuntos.Rows.Add(x, y, z);

            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            txtX.Focus();

            calculado = false;
            lblArea.Text = "Área: --";
            lblVolumen.Text = "Volumen: --";
            celdas.Clear();
            puntosGL.Clear();
            glControl.Invalidate();
        }

        private void btnEliminarPunto_Click(object sender, EventArgs e)
        {
            if (dgvPuntos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un punto de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvPuntos.SelectedRows[0].Index;
            dgvPuntos.Rows.RemoveAt(index);
            terrenoController.ObtenerPuntos().RemoveAt(index);

            calculado = false;
            lblArea.Text = "Área: --";
            lblVolumen.Text = "Volumen: --";
            celdas.Clear();
            puntosGL.Clear();
            glControl.Invalidate();
        }

        private void btnLimpiarPuntos_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show(
                "¿Desea limpiar todos los puntos?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                dgvPuntos.Rows.Clear();
                terrenoController.LimpiarPuntos();
                calculado = false;
                lblArea.Text = "Área: --";
                lblVolumen.Text = "Volumen: --";
                celdas.Clear();
                puntosGL.Clear();
                glControl.Invalidate();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (terrenoController.ObtenerPuntos().Count < 3)
            {
                MessageBox.Show("Ingrese al menos 3 puntos para calcular.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double area = terrenoController.CalcularArea();
                double volumen = terrenoController.CalcularVolumen();

                lblArea.Text = "Área: " + area + " m²";
                lblVolumen.Text = "Volumen: " + volumen + " m³";

                calculado = true;
                PrepararDatosGL();
                glControl.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
        }

        private void CargarProyectosGuardados()
        {
            cmbProyectos.Items.Clear();
            var terrenos = terrenoController.ObtenerTodosLosTerrenos();

            if (terrenos.Count == 0)
            {
                cmbProyectos.Items.Add("Sin proyectos guardados");
                cmbProyectos.SelectedIndex = 0;
                return;
            }

            foreach (var t in terrenos)
                cmbProyectos.Items.Add(t.Id + " - " + t.NombreProyecto + " (" + t.FechaRegistro + ")");

            cmbProyectos.SelectedIndex = 0;
        }

        private void btnVerTerreno_Click(object sender, EventArgs e)
{
    if (cmbProyectos.Items.Count == 0 ||
        cmbProyectos.SelectedItem.ToString() == "Sin proyectos guardados")
    {
        MessageBox.Show("No hay proyectos guardados para visualizar.",
            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

    int idTerreno = int.Parse(cmbProyectos.SelectedItem.ToString().Split('-')[0].Trim());
    var terreno = terrenoController.ObtenerTerrenoPorId(idTerreno);
    var puntos = terrenoController.ObtenerCoordenadas(idTerreno);

    if (puntos.Count == 0)
    {
        MessageBox.Show("Este terreno no tiene coordenadas registradas.",
            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    terrenoController.LimpiarPuntos();
    foreach (var p in puntos)
        terrenoController.AgregarPunto(p.X, p.Y, p.Z);

    lblArea.Text = "Área: " + terreno.Area + " m²";
    lblVolumen.Text = "Volumen: " + terreno.Volumen + " m³";

    calculado = true;
    PrepararDatosGL();
    glControl.Invalidate();

    MessageBox.Show(
        "Terreno: " + terreno.NombreProyecto +
        "\nFecha: " + terreno.FechaRegistro +
        "\nÁrea: " + terreno.Area + " m²" +
        "\nVolumen: " + terreno.Volumen + " m³" +
        "\nObservaciones: " + terreno.Observaciones,
        "Detalle del Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblMensaje_Proyecto.Visible = false;

            if (txtNombreProyecto.Text.Trim() == "")
            {
                lblMensaje_Proyecto.Text = "El nombre del proyecto es obligatorio*";
                lblMensaje_Proyecto.Visible = true;
                return;
            }

            if (!calculado)
            {
                MessageBox.Show("Primero calcule el volumen antes de guardar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (terrenoController.GuardarTerreno(txtNombreProyecto.Text.Trim(), textBox1.Text.Trim()))
            {
                MessageBox.Show("Terreno guardado con éxito.", "GeoIntegral",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreProyecto.Text = "";
                textBox1.Text = "";
                dgvPuntos.Rows.Clear();
                terrenoController.LimpiarPuntos();
                calculado = false;
                lblArea.Text = "Área: --";
                lblVolumen.Text = "Volumen: --";
                celdas.Clear();
                puntosGL.Clear();
                glControl.Invalidate();
            }
        }
    }
}