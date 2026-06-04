using GeoIntegral.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Usuario_Terrenos : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private TerrenoController terrenoController = new TerrenoController();
        private bool calculado = false;

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

            btnAgregarPunto.Click += new EventHandler(btnAgregarPunto_Click);
            btnEliminarPunto.Click += new EventHandler(btnEliminarPunto_Click);
            btnLimpiarPuntos.Click += new EventHandler(btnLimpiarPuntos_Click);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
        }

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

            // Reset resultados al agregar nuevo punto
            calculado = false;
            lblArea.Text = "Área: --";
            lblVolumen.Text = "Volumen: --";
            picGrafica.Image = null;
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

            var puntos = terrenoController.ObtenerPuntos();
            puntos.RemoveAt(index);

            calculado = false;
            lblArea.Text = "Área: --";
            lblVolumen.Text = "Volumen: --";
            picGrafica.Image = null;
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
                picGrafica.Image = null;
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

                lblArea.Text = $"Área: {area} m²";
                lblVolumen.Text = $"Volumen: {volumen} m³";

                calculado = true;
                DibujarGrafica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
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
                MessageBox.Show("¡Terreno guardado con éxito!", "GeoIntegral",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar todo
                txtNombreProyecto.Text = "";
                textBox1.Text = "";
                dgvPuntos.Rows.Clear();
                terrenoController.LimpiarPuntos();
                calculado = false;
                lblArea.Text = "Área: --";
                lblVolumen.Text = "Volumen: --";
                picGrafica.Image = null;
            }
        }

        private void DibujarGrafica()
        {
            var puntos = terrenoController.ObtenerPuntos();
            if (puntos.Count == 0) return;

            int w = picGrafica.Width;
            int h = picGrafica.Height;
            Bitmap bmp = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(20, 20, 40));

                double xMin = double.MaxValue, xMax = double.MinValue;
                double yMin = double.MaxValue, yMax = double.MinValue;
                double zMin = double.MaxValue, zMax = double.MinValue;

                foreach (var p in puntos)
                {
                    if (p.X < xMin) xMin = p.X;
                    if (p.X > xMax) xMax = p.X;
                    if (p.Y < yMin) yMin = p.Y;
                    if (p.Y > yMax) yMax = p.Y;
                    if (p.Z < zMin) zMin = p.Z;
                    if (p.Z > zMax) zMax = p.Z;
                }

                double rangoX = xMax - xMin == 0 ? 1 : xMax - xMin;
                double rangoY = yMax - yMin == 0 ? 1 : yMax - yMin;
                double rangoZ = zMax - zMin == 0 ? 1 : zMax - zMin;

                int margen = 30;

                foreach (var p in puntos)
                {
                    // Proyección isométrica simple
                    double px = (p.X - xMin) / rangoX;
                    double py = (p.Y - yMin) / rangoY;
                    double pz = (p.Z - zMin) / rangoZ;

                    float screenX = (float)(margen + px * (w - 2 * margen) * 0.7 - py * (w - 2 * margen) * 0.3);
                    float screenY = (float)(h - margen - py * (h - 2 * margen) * 0.5 - pz * (h - 2 * margen) * 0.4);

                    // Color según altura
                    int r = (int)(pz * 255);
                    int b = (int)((1 - pz) * 255);
                    Color color = Color.FromArgb(r, 100, b);

                    g.FillEllipse(new SolidBrush(color), screenX - 5, screenY - 5, 10, 10);

                    // Etiqueta
                    g.DrawString($"({p.X},{p.Y},{p.Z})",
                        new Font("Arial", 7), Brushes.White, screenX + 6, screenY - 6);
                }

                // Conectar puntos
                using (Pen pen = new Pen(Color.FromArgb(100, 0, 200, 255), 1))
                {
                    for (int i = 0; i < puntos.Count; i++)
                    {
                        int j = (i + 1) % puntos.Count;

                        double px1 = (puntos[i].X - xMin) / rangoX;
                        double py1 = (puntos[i].Y - yMin) / rangoY;
                        double pz1 = (puntos[i].Z - zMin) / rangoZ;
                        float sx1 = (float)(margen + px1 * (w - 2 * margen) * 0.7 - py1 * (w - 2 * margen) * 0.3);
                        float sy1 = (float)(h - margen - py1 * (h - 2 * margen) * 0.5 - pz1 * (h - 2 * margen) * 0.4);

                        double px2 = (puntos[j].X - xMin) / rangoX;
                        double py2 = (puntos[j].Y - yMin) / rangoY;
                        double pz2 = (puntos[j].Z - zMin) / rangoZ;
                        float sx2 = (float)(margen + px2 * (w - 2 * margen) * 0.7 - py2 * (w - 2 * margen) * 0.3);
                        float sy2 = (float)(h - margen - py2 * (h - 2 * margen) * 0.5 - pz2 * (h - 2 * margen) * 0.4);

                        g.DrawLine(pen, sx1, sy1, sx2, sy2);
                    }
                }

                // Leyenda
                g.DrawString("Gráfica 3D del Terreno (Proyección Isométrica)",
                    new Font("Arial", 8, FontStyle.Bold), Brushes.Yellow, 5, 5);
                g.DrawString("● Color: Azul=bajo  Rojo=alto",
                    new Font("Arial", 7), Brushes.LightGray, 5, h - 20);
            }

            picGrafica.Image = bmp;
        }
    }
}