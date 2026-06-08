using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Controller;
using GeoIntegral.Models;

namespace GeoIntegral.Views
{
    public partial class Usuario_Facturas : Form
    {
        private readonly bool _esAdmin;
        private readonly ClienteController clienteController = new ClienteController();
        private readonly FacturaController facturaController = new FacturaController();
        private readonly CotizacionController cotizacionController = new CotizacionController();

        public Usuario_Facturas(Size tamano, bool esAdmin)
        {
            InitializeComponent();
            this.Size = tamano;
            _esAdmin = esAdmin;

            btnCambiarEstado.Visible = esAdmin;
            btnEliminar.Visible = esAdmin;

            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;

            // eventos
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnConvertir.Click += btnConvertir_Click;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            btnEliminar.Click += btnEliminar_Click;
            

            CargarFiltroClientes();
            CargarFacturas();
        }

        // ── CARGA INICIAL ────────────────────────────────────────

        private void CargarFiltroClientes()
        {
            cmbFiltroCliente.Items.Clear();
            cmbFiltroCliente.Items.Add("Todos");

            var clientes = clienteController.ObtenerTodosLosClientes();
            foreach (var c in clientes)
                cmbFiltroCliente.Items.Add(c.Identificacion + " - " + c.Nombre);

            cmbFiltroCliente.SelectedIndex = 0;

            if (cmbFiltroEstado.Items.Count == 0)
            {
                cmbFiltroEstado.Items.Add("Todos");
                cmbFiltroEstado.Items.Add("Activa");
                cmbFiltroEstado.Items.Add("Inactiva");
            }
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void CargarFacturas(List<Factura> lista = null)
        {
            dgvFacturas.Rows.Clear();

            var facturas = lista ?? facturaController.ObtenerTodas();
            var clientes = clienteController.ObtenerTodosLosClientes();
            var cotizaciones = cotizacionController.ObtenerTodas();

            foreach (var f in facturas)
            {
                var cliente = clientes.Find(c => c.Identificacion == f.IdentificacionCliente);
                var cotizacion = cotizaciones.Find(c => c.IdCotizacion == f.IdCotizacion);

                string nombreCliente = cliente != null ? cliente.Nombre : f.IdentificacionCliente.ToString();
                string costoTotal = cotizacion != null ? "$" + cotizacion.CostoTotal.ToString() : "--";

                dgvFacturas.Rows.Add(
                    f.NumeroFactura,
                    nombreCliente,
                    f.IdCotizacion,
                    costoTotal,
                    f.FechaEmision,
                    f.Estado
                );
            }

            lblTotalFacturas.Text = "Total: " + dgvFacturas.Rows.Count + " factura(s)";
        }

        // ── FILTROS ──────────────────────────────────────────────

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var todas = facturaController.ObtenerTodas();

            if (cmbFiltroCliente.SelectedIndex > 0)
            {
                long idCliente = long.Parse(cmbFiltroCliente.SelectedItem.ToString().Split('-')[0].Trim());
                todas = todas.Where(f => f.IdentificacionCliente == idCliente).ToList();
            }

            if (cmbFiltroEstado.SelectedItem.ToString() != "Todos")
                todas = todas.Where(f => f.Estado == cmbFiltroEstado.SelectedItem.ToString()).ToList();

            todas = todas.Where(f =>
            {
                if (DateTime.TryParse(f.FechaEmision, out DateTime fecha))
                    return fecha >= dtpDesde.Value.Date && fecha <= dtpHasta.Value.Date;
                return true;
            }).ToList();

            CargarFacturas(todas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbFiltroCliente.SelectedIndex = 0;
            cmbFiltroEstado.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarFacturas();
        }

        // ── ACCIONES ─────────────────────────────────────────────

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            var cotizaciones = cotizacionController.ObtenerTodas()
                .Where(c => c.Estado == "Pendiente").ToList();

            if (cotizaciones.Count == 0)
            {
                MessageBox.Show("No hay cotizaciones pendientes para convertir.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var opciones = cotizaciones.Select(c =>
                c.IdCotizacion + " - " + c.Material + " - $" + c.CostoTotal + " (" + c.Fecha + ")").ToArray();

            string seleccion = null;

            using (var dialogo = new Form())
            {
                dialogo.Text = "Seleccionar Cotización";
                dialogo.Size = new Size(450, 300);
                dialogo.StartPosition = FormStartPosition.CenterParent;

                var lista = new ListBox { Dock = DockStyle.Fill };
                lista.Items.AddRange(opciones);

                var btnOk = new Button
                {
                    Text = "Convertir",
                    Dock = DockStyle.Bottom,
                    Height = 40
                };

                btnOk.Click += (s, ev) =>
                {
                    if (lista.SelectedItem != null)
                    {
                        seleccion = lista.SelectedItem.ToString();
                        dialogo.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Seleccione una cotización.");
                };

                dialogo.Controls.Add(lista);
                dialogo.Controls.Add(btnOk);
                dialogo.ShowDialog();
            }

            if (seleccion == null) return;

            int idCotizacion = int.Parse(seleccion.Split('-')[0].Trim());
            var cotizacion = cotizaciones.Find(c => c.IdCotizacion == idCotizacion);

            var confirmacion = MessageBox.Show(
                "¿Convertir cotización #" + idCotizacion + " en factura?\n\nMaterial: " + cotizacion.Material + "\nCosto: $" + cotizacion.CostoTotal,
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            if (facturaController.GenerarFactura(idCotizacion, cotizacion.IdentificacionCliente))
            {
                cotizacionController.CambiarEstado(idCotizacion, "Facturada");
                MessageBox.Show("Factura generada con éxito.", "GeoIntegral",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarFacturas();
            }
            else
            {
                MessageBox.Show("Error al generar la factura.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numero = int.Parse(dgvFacturas.SelectedRows[0].Cells["NumeroFactura"].Value.ToString());
            var factura = facturaController.ObtenerPorNumero(numero);
            var cotizacion = cotizacionController.ObtenerPorId(factura.IdCotizacion);
            var clientes = clienteController.ObtenerTodosLosClientes();
            var cliente = clientes.Find(c => c.Identificacion == factura.IdentificacionCliente);

            string nombreCliente = cliente != null ? cliente.Nombre : factura.IdentificacionCliente.ToString();
            string costoTotal = cotizacion != null ? "$" + cotizacion.CostoTotal.ToString() : "--";
            string material = cotizacion != null ? cotizacion.Material : "--";

            string detalle =
                "N° Factura:     " + factura.NumeroFactura + "\n" +
                "Fecha Emisión:  " + factura.FechaEmision + "\n" +
                "Estado:         " + factura.Estado + "\n\n" +
                "Cliente:        " + nombreCliente + "\n" +
                "Identificación: " + factura.IdentificacionCliente + "\n\n" +
                "Cotización Ref: #" + factura.IdCotizacion + "\n" +
                "Material:       " + material + "\n" +
                "Costo Total:    " + costoTotal;

            MessageBox.Show(detalle, "Detalle Factura",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numero = int.Parse(dgvFacturas.SelectedRows[0].Cells["NumeroFactura"].Value.ToString());
            var factura = facturaController.ObtenerPorNumero(numero);

            string nuevoEstado = factura.Estado == "Activa" ? "Inactiva" : "Activa";

            var confirmacion = MessageBox.Show(
                "¿Cambiar estado de la factura #" + numero + " a '" + nuevoEstado + "'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                facturaController.CambiarEstado(numero, nuevoEstado);
                CargarFacturas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numero = int.Parse(dgvFacturas.SelectedRows[0].Cells["NumeroFactura"].Value.ToString());

            var confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar la factura #" + numero + "? Esta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                facturaController.Eliminar(numero);
                CargarFacturas();
                MessageBox.Show("Factura eliminada.", "GeoIntegral",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}