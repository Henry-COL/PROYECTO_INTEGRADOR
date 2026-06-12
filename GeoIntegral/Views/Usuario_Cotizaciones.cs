using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeoIntegral.Controller;
using GeoIntegral.Models;

namespace GeoIntegral.Views
{
    public partial class Usuario_Cotizaciones : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;

        // Controladores
        private ClienteController clienteController = new ClienteController();
        private TerrenoController terrenoController = new TerrenoController();
        private MaterialController materialController = new MaterialController();
        private CotizacionController cotizacionController = new CotizacionController();

        // Listas en memoria para mejorar el rendimiento y evitar consultas repetitivas
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Terreno> listaTerrenos = new List<Terreno>();
        private List<Material> listaMateriales = new List<Material>();

        public Usuario_Cotizaciones(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;

            // Configuración inicial de la tabla
            dtgCotizaciones.AllowUserToAddRows = false;
            dtgCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCotizaciones.ReadOnly = true;
            EstilarTabla();

            lblCostoTotal.Text = "$ 0.00";
            lblCostoTotal.ForeColor = System.Drawing.Color.White;

            // Enlazar eventos de cálculo en tiempo real
            cmbMateriales.SelectedIndexChanged += new EventHandler(ActualizarCostoTotal);
            comboBox1.SelectedIndexChanged += new EventHandler(ActualizarCostoTotal); // Nota: Cambiado de comboBox1 a cmbTerrenos

            // Carga inicial de datos
            CargarCombos();
            CargarCotizaciones();
        }

        private void CargarCombos()
        {
            // 1. Cargar Clientes
            cmbClientes.Items.Clear();
            listaClientes = clienteController.ObtenerTodosLosClientes() ?? new List<Cliente>();
            foreach (var c in listaClientes)
            {
                cmbClientes.Items.Add($"{c.Identificacion} - {c.Nombre}");
            }

            // 2. Cargar Terrenos
            comboBox1.Items.Clear();
            listaTerrenos = terrenoController.ObtenerTodosLosTerrenos() ?? new List<Terreno>();
            foreach (var t in listaTerrenos)
            {
                comboBox1.Items.Add($"{t.Id} - {t.NombreProyecto} ({t.Volumen:N2} m³)");
            }

            // 3. Cargar Materiales
            cmbMateriales.Items.Clear();
            listaMateriales = materialController.ObtenerTodosLosMateriales() ?? new List<Material>();
            foreach (var m in listaMateriales)
            {
                cmbMateriales.Items.Add($"{m.Id} - {m.Nombre} (${m.CostoUnidad:N2}/m³)");
            }
        }

        private void ActualizarCostoTotal(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || cmbMateriales.SelectedItem == null)
            {
                lblCostoTotal.Text = "Calculando...";
                lblCostoTotal.ForeColor = System.Drawing.Color.White;
                return;
            }

            try
            {
                // Extraer de forma segura el ID del Terreno (toma todo lo que esté antes del primer espacio o guion)
                string terrenoStr = comboBox1.SelectedItem.ToString();
                int idTerreno = int.Parse(terrenoStr.Split(' ')[0].Trim());
                var terreno = listaTerrenos.Find(t => t.Id == idTerreno);

                // Extraer de forma segura el ID del Material
                string materialStr = cmbMateriales.SelectedItem.ToString();
                int idMaterial = int.Parse(materialStr.Split(' ')[0].Trim());
                var material = listaMateriales.Find(m => m.Id == idMaterial);

                if (terreno != null && material != null)
                {
                    double costoTotal = terreno.Volumen * material.CostoUnidad;
                    lblCostoTotal.Text = "$ " + costoTotal.ToString("N2");
                    lblCostoTotal.ForeColor = System.Drawing.Color.Khaki;
                }
                else
                {
                    lblCostoTotal.Text = "Calculando...";
                    lblCostoTotal.ForeColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                lblCostoTotal.Text = "Calculando...";
                lblCostoTotal.ForeColor = System.Drawing.Color.White;
            }
        }

        private void CargarCotizaciones()
        {
            dtgCotizaciones.Rows.Clear();
            var cotizaciones = cotizacionController.ObtenerTodas() ?? new List<Cotizacion>();

            foreach (var c in cotizaciones)
            {
                var cliente = listaClientes.Find(cl => cl.Identificacion == c.IdentificacionCliente);
                var terreno = listaTerrenos.Find(t => t.Id == c.IdTerreno);

                string nombreCliente = cliente != null ? cliente.Nombre : c.IdentificacionCliente.ToString();
                string nombreTerreno = terreno != null ? terreno.NombreProyecto : c.IdTerreno.ToString();

                dtgCotizaciones.Rows.Add(
                    c.IdCotizacion,
                    nombreCliente,
                    nombreTerreno,
                    c.Material,
                    "$" + c.CostoTotal.ToString("N2"),
                    c.Fecha,
                    c.Estado
                );
            }
        }

        private void EstilarTabla()
        {
            dtgCotizaciones.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 33);
            dtgCotizaciones.GridColor = System.Drawing.Color.FromArgb(30, 45, 60);
            dtgCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dtgCotizaciones.RowHeadersVisible = false;
            dtgCotizaciones.AllowUserToAddRows = false;
            dtgCotizaciones.AllowUserToResizeRows = false;
            dtgCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgCotizaciones.ReadOnly = true;
            dtgCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgCotizaciones.EnableHeadersVisualStyles = false;

            // Encabezado
            dtgCotizaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 32, 46);
            dtgCotizaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 230);
            dtgCotizaciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            dtgCotizaciones.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dtgCotizaciones.ColumnHeadersHeight = 38;
            dtgCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            // Filas normales
            dtgCotizaciones.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 34, 48);
            dtgCotizaciones.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dtgCotizaciones.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            dtgCotizaciones.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // Fila seleccionada
            dtgCotizaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(7, 16, 30);
            dtgCotizaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Filas alternadas
            dtgCotizaciones.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 28, 40);
            dtgCotizaciones.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(26, 95, 80);
            dtgCotizaciones.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dtgCotizaciones.RowTemplate.Height = 32;
        }

        private void btnGenerarCotizacion_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null ||
                comboBox1.SelectedItem == null ||
                cmbMateriales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione cliente, terreno y material.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Extraer datos seleccionados usando las listas en memoria
                long idCliente = long.Parse(cmbClientes.SelectedItem.ToString().Split(' ')[0].Trim());

                string terrenoStr = comboBox1.SelectedItem.ToString();
                int idTerreno = int.Parse(terrenoStr.Split(' ')[0].Trim());
                var terreno = listaTerrenos.Find(t => t.Id == idTerreno);

                string materialStr = cmbMateriales.SelectedItem.ToString();
                int idMaterial = int.Parse(materialStr.Split(' ')[0].Trim());
                var material = listaMateriales.Find(m => m.Id == idMaterial);

                if (terreno == null || material == null)
                {
                    MessageBox.Show("Error al recuperar los datos internos del terreno o material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double costoFinal = terreno.Volumen * material.CostoUnidad;

                var confirmacion = MessageBox.Show(
                    $"¿Generar cotización?\n\nCliente: {cmbClientes.SelectedItem}\nTerreno: {terreno.NombreProyecto}\nMaterial: {material.Nombre}\nCosto Total: ${costoFinal:N2}",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (cotizacionController.GenerarCotizacion(
                        idCliente, idTerreno, material.Nombre,
                        terreno.Volumen, material.CostoUnidad))
                    {
                        MessageBox.Show("¡Cotización generada con éxito!", "GeoIntegral",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCotizaciones();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar cotización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dtgCotizaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Intenta buscar la celda por índice (0) si el nombre string te llega a fallar en el diseño
                var filaSeleccionada = dtgCotizaciones.SelectedRows[0];
                int id = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                var cotizacion = cotizacionController.ObtenerPorId(id);
                if (cotizacion == null) return;

                var cliente = listaClientes.Find(c => c.Identificacion == cotizacion.IdentificacionCliente);
                var terreno = listaTerrenos.Find(t => t.Id == cotizacion.IdTerreno);

                string detalle = $"╔══════════════════════════════╗\n" +
                                 $"         DETALLE COTIZACIÓN\n" +
                                 $"╚══════════════════════════════╝\n\n" +
                                 $"ID Cotización:  {cotizacion.IdCotizacion}\n" +
                                 $"Fecha:          {cotizacion.Fecha}\n" +
                                 $"Estado:         {cotizacion.Estado}\n\n" +
                                 $"Cliente:        {(cliente != null ? cliente.Nombre : cotizacion.IdentificacionCliente.ToString())}\n" +
                                 $"Identificación: {cotizacion.IdentificacionCliente}\n\n" +
                                 $"Proyecto:       {(terreno != null ? terreno.NombreProyecto : cotizacion.IdTerreno.ToString())}\n" +
                                 $"Volumen:        {(terreno != null ? terreno.Volumen.ToString("N2") : "--")} m³\n\n" +
                                 $"Material:       {cotizacion.Material}\n" +
                                 $"Costo Total:    ${cotizacion.CostoTotal:N2}";

                MessageBox.Show(detalle, "Detalle Cotización",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
        }
    }
}