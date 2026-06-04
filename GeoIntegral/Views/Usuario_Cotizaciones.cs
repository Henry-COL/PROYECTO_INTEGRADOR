using System;
using System.Drawing;
using System.Windows.Forms;
using GeoIntegral.Controller;
using GeoIntegral.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeoIntegral.Views
{
    public partial class Usuario_Cotizaciones : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private ClienteController clienteController = new ClienteController();
        private TerrenoController terrenoController = new TerrenoController();
        private MaterialController materialController = new MaterialController();
        private CotizacionController cotizacionController = new CotizacionController();

        public Usuario_Cotizaciones(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            lblCostoTotal.Text = "Costo Total: --";

            cmbMateriales.SelectedIndexChanged += new EventHandler(ActualizarCostoTotal);
            comboBox1.SelectedIndexChanged += new EventHandler(ActualizarCostoTotal);

            CargarCombos();
            CargarCotizaciones();
        }

        private void CargarCombos()
        {
            // Clientes
            cmbClientes.Items.Clear();
            var clientes = clienteController.ObtenerTodosLosClientes();
            foreach (var c in clientes)
                cmbClientes.Items.Add($"{c.Identificacion} - {c.Nombre}");

            // Terrenos
            comboBox1.Items.Clear();
            var terrenos = terrenoController.ObtenerTodosLosTerrenos();
            foreach (var t in terrenos)
                comboBox1.Items.Add(
                    t.Id + " - " +
                    t.NombreProyecto +
                    " (" + t.Volumen.ToString("N2") + " m³)"
                    );

            // Materiales
            cmbMateriales.Items.Clear();
            var materiales = materialController.ObtenerTodosLosMateriales();
            foreach (var m in materiales)
                cmbMateriales.Items.Add(
                    m.Id + " - " +
                    m.Nombre +
                    " ($" + m.CostoUnidad.ToString("N2") + "/m³)"
                    );
        }

        private void ActualizarCostoTotal(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || cmbMateriales.SelectedItem == null)
            {
                lblCostoTotal.Text = "Costo Total: --";
                return;
            }

            try
            {
                // Extraer volumen del terreno seleccionado
                string terrenoStr = comboBox1.SelectedItem.ToString();
                int idTerreno = int.Parse(terrenoStr.Split('-')[0].Trim());
                var terrenos = terrenoController.ObtenerTodosLosTerrenos();
                var terreno = terrenos.Find(t => t.Id == idTerreno);

                // Extraer costo del material seleccionado
                string materialStr = cmbMateriales.SelectedItem.ToString();
                int idMaterial = int.Parse(materialStr.Split('-')[0].Trim());
                var materiales = materialController.ObtenerTodosLosMateriales();
                var material = materiales.Find(m => m.Id == idMaterial);

                double costoTotal = terreno.Volumen * material.CostoUnidad;
                lblCostoTotal.Text = "$" + costoTotal.ToString("N2");
            }
            catch
            {
                lblCostoTotal.Text = "Calculando...";
            }
        }

        private void CargarCotizaciones()
        {
            dataGridView1.Rows.Clear();
            var cotizaciones = cotizacionController.ObtenerTodas();
            var clientes = clienteController.ObtenerTodosLosClientes();
            var terrenos = terrenoController.ObtenerTodosLosTerrenos();

            foreach (var c in cotizaciones)
            {
                var cliente = clientes.Find(cl => cl.Identificacion == c.IdentificacionCliente);
                var terreno = terrenos.Find(t => t.Id == c.IdTerreno);

                string nombreCliente = cliente != null ? cliente.Nombre : c.IdentificacionCliente.ToString();
                string nombreTerreno = terreno != null ? terreno.NombreProyecto : c.IdTerreno.ToString();

                dataGridView1.Rows.Add(
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
                // Extraer datos seleccionados
                long idCliente = long.Parse(cmbClientes.SelectedItem.ToString().Split('-')[0].Trim());

                string terrenoStr = comboBox1.SelectedItem.ToString();
                int idTerreno = int.Parse(terrenoStr.Split('-')[0].Trim());
                var terrenos = terrenoController.ObtenerTodosLosTerrenos();
                var terreno = terrenos.Find(t => t.Id == idTerreno);

                string materialStr = cmbMateriales.SelectedItem.ToString();
                int idMaterial = int.Parse(materialStr.Split('-')[0].Trim());
                var materiales = materialController.ObtenerTodosLosMateriales();
                var material = materiales.Find(m => m.Id == idMaterial);

                var confirmacion = MessageBox.Show(
                    $"¿Generar cotización?\n\nCliente: {cmbClientes.SelectedItem}\nTerreno: {terreno.NombreProyecto}\nMaterial: {material.Nombre}\nCosto Total: ${terreno.Volumen * material.CostoUnidad}",
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
                MessageBox.Show("Error al generar cotización: " + ex.Message);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["IdCotizacion"].Value.ToString());
            var cotizacion = cotizacionController.ObtenerPorId(id);
            var clientes = clienteController.ObtenerTodosLosClientes();
            var terrenos = terrenoController.ObtenerTodosLosTerrenos();

            var cliente = clientes.Find(c => c.Identificacion == cotizacion.IdentificacionCliente);
            var terreno = terrenos.Find(t => t.Id == cotizacion.IdTerreno);

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
                             $"Costo Total:    ${cotizacion.CostoTotal}";

            MessageBox.Show(detalle, "Detalle Cotización",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
        }
    }
}