using GeoIntegral.Controller;
using GeoIntegral.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextFont = iTextSharp.text.Font;
using ITextRectangle = iTextSharp.text.Rectangle;

namespace GeoIntegral.Views
{
    public partial class Usuario_Facturas : Form
    {
        private readonly bool _esAdmin;
        private readonly TerrenoController terrenoController = new TerrenoController();
        private readonly ClienteController clienteController = new ClienteController();
        private readonly FacturaController facturaController = new FacturaController();
        private readonly CotizacionController cotizacionController = new CotizacionController();

        public Usuario_Facturas(Size tamano, bool esAdmin)
        {
            InitializeComponent();
            this.Size = tamano;
            _esAdmin = esAdmin;

            EstilarTabla();
            btnCambiarEstado.Visible = esAdmin;
            btnEliminar.Visible = esAdmin;

            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarFiltroClientes();
            CargarFacturas();
        }

        // ── CARGA INICIAL ────────────────────────────────────────


        private void EstilarTabla()
        {
            dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 33);
            dgvFacturas.GridColor = System.Drawing.Color.FromArgb(30, 45, 60);
            dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToResizeRows = false;
            dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.ReadOnly = true;
            dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.EnableHeadersVisualStyles = false;

            // Encabezado
            dgvFacturas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 32, 46);
            dgvFacturas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 230);
            dgvFacturas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            dgvFacturas.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvFacturas.ColumnHeadersHeight = 38;
            dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            // Filas normales
            dgvFacturas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 34, 48);
            dgvFacturas.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvFacturas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            dgvFacturas.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // Fila seleccionada
            dgvFacturas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(7, 16, 30);
            dgvFacturas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Filas alternadas
            dgvFacturas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 28, 40);
            dgvFacturas.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(26, 95, 80);
            dgvFacturas.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dgvFacturas.RowTemplate.Height = 32;
        }


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

            lblTotalFacturas.Text = dgvFacturas.Rows.Count + " factura(s)";
        }

        // ── FILTROS ──────────────────────────────────────────────

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var todas = facturaController.ObtenerTodas();

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser mayor que la fecha final.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

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

        // ── DESCARGAR PDF ────────────────────────────────────────


        private void btnDescargar_Click(object sender, EventArgs e)
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
            var cliente = clienteController.ObtenerTodosLosClientes()
                .Find(c => c.Identificacion == factura.IdentificacionCliente);
            var terreno = cotizacion != null
                ? terrenoController.ObtenerTerrenoPorId(cotizacion.IdTerreno)
                : null;

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = $"PDF-GEOINTEGRAL-FACTURA-{factura.IdentificacionCliente}_{factura.NumeroFactura}.pdf";
                sfd.Title = "Guardar Factura como PDF";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    GenerarPdfFactura(sfd.FileName, factura, cliente, cotizacion, terreno);

                    var abrir = MessageBox.Show(
                        "Factura PDF generada con éxito.\n\n¿Desea abrirla ahora?",
                        "GeoIntegral", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (abrir == DialogResult.Yes)
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarPdfFactura(string rutaArchivo, Factura factura, Cliente cliente, Cotizacion cotizacion, Terreno terreno)
        {
            // Colores del tema corporativo
            BaseColor azulOscuro = new BaseColor(15, 23, 33);
            BaseColor azulHeader = new BaseColor(20, 32, 46);
            BaseColor doradoAcento = new BaseColor(212, 175, 55);
            BaseColor doradoClaro = new BaseColor(250, 243, 224);
            BaseColor grisTexto = new BaseColor(100, 110, 120);
            BaseColor grisLinea = new BaseColor(225, 228, 232);
            BaseColor filaAlterna = new BaseColor(245, 247, 249);
            BaseColor verdeTotal = new BaseColor(18, 95, 80);
            BaseColor blanco = BaseColor.WHITE;
            BaseColor celesteTenue = new BaseColor(180, 210, 230);

            Document doc = new Document(PageSize.A4, 36, 36, 36, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // Fuentes
            iTextFont fontTituloEmpresa = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, blanco);
            iTextFont fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, celesteTenue);
            iTextFont fontFacturaTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, doradoAcento);
            iTextFont fontNumeroFactura = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, blanco);
            iTextFont fontEstadoFactura = FontFactory.GetFont(FontFactory.HELVETICA, 9, celesteTenue);
            iTextFont fontSeccionTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9.5f, blanco);
            iTextFont fontEtiqueta = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, grisTexto);
            iTextFont fontValor = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
            iTextFont fontTablaHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9.5f, blanco);
            iTextFont fontTablaCelda = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
            iTextFont fontTotalLabel = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, grisTexto);
            iTextFont fontTotalValor = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, verdeTotal);
            iTextFont fontPie = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8, BaseColor.GRAY);

            // ── ENCABEZADO CON LOGO ──────────────────────────────────────
            PdfPTable headerTable = new PdfPTable(2) { WidthPercentage = 100 };
            headerTable.SetWidths(new float[] { 1.3f, 1f });

            PdfPCell celdaEmpresa = new PdfPCell();
            celdaEmpresa.Border = ITextRectangle.NO_BORDER;
            celdaEmpresa.BackgroundColor = azulOscuro;
            celdaEmpresa.PaddingTop = 18;
            celdaEmpresa.PaddingBottom = 18;
            celdaEmpresa.PaddingLeft = 20;
            celdaEmpresa.VerticalAlignment = Element.ALIGN_MIDDLE;

            string rutaLogo = ResolveRutaLogo("GeoIntegral-LogoTipo.png");
            if (File.Exists(rutaLogo))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                logo.ScaleToFit(170, 55);
                celdaEmpresa.AddElement(logo);
                celdaEmpresa.AddElement(new Paragraph("Soluciones Topográficas e Ingeniería de Terrenos",
                    fontSubtitulo)
                { SpacingBefore = 6 });
                celdaEmpresa.AddElement(new Paragraph("contacto@geointegral.com", fontSubtitulo));
            }
            else
            {
                celdaEmpresa.AddElement(new Paragraph("GeoIntegral", fontTituloEmpresa));
                celdaEmpresa.AddElement(new Paragraph("Soluciones Topográficas e Ingeniería de Terrenos\ncontacto@geointegral.com",
                    fontSubtitulo)
                { SpacingBefore = 4 });
            }
            headerTable.AddCell(celdaEmpresa);

            PdfPCell celdaFacturaTitulo = new PdfPCell();
            celdaFacturaTitulo.Border = ITextRectangle.NO_BORDER;
            celdaFacturaTitulo.BackgroundColor = azulOscuro;
            celdaFacturaTitulo.HorizontalAlignment = Element.ALIGN_RIGHT;
            celdaFacturaTitulo.VerticalAlignment = Element.ALIGN_MIDDLE;
            celdaFacturaTitulo.PaddingRight = 20;

            celdaFacturaTitulo.AddElement(new Paragraph("FACTURA", fontFacturaTitulo) { Alignment = Element.ALIGN_RIGHT });
            celdaFacturaTitulo.AddElement(new Paragraph("N° " + factura.NumeroFactura.ToString("D6"), fontNumeroFactura)
            { Alignment = Element.ALIGN_RIGHT, SpacingBefore = 6 });
            celdaFacturaTitulo.AddElement(new Paragraph(factura.Estado.ToUpper(), fontEstadoFactura)
            { Alignment = Element.ALIGN_RIGHT, SpacingBefore = 2 });
            headerTable.AddCell(celdaFacturaTitulo);

            doc.Add(headerTable);

            // Línea dorada decorativa
            PdfPTable lineaDorada = new PdfPTable(1) { WidthPercentage = 100 };
            PdfPCell celdaLinea = new PdfPCell { FixedHeight = 4f, BackgroundColor = doradoAcento, Border = ITextRectangle.NO_BORDER };
            lineaDorada.AddCell(celdaLinea);
            doc.Add(lineaDorada);

            doc.Add(new Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 10)));

            // ── DATOS DE CLIENTE Y FACTURA ────────────────────────────────
            PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100, SpacingAfter = 18 };
            infoTable.SetWidths(new float[] { 1f, 1f });
            infoTable.DefaultCell.Border = ITextRectangle.NO_BORDER;

            PdfPCell celdaCliente = CrearCajaInfo("DATOS DEL CLIENTE",
                new[]
                {
            ("Nombre:", cliente != null ? cliente.Nombre : "N/D"),
            ("Identificación:", factura.IdentificacionCliente.ToString()),
            ("Teléfono:", cliente != null ? cliente.Telefono : "N/D"),
            ("Correo:", cliente != null ? cliente.Correo : "N/D")
                }, fontSeccionTitulo, fontEtiqueta, fontValor, azulHeader, grisLinea);

            PdfPCell celdaFactura = CrearCajaInfo("DATOS DE LA FACTURA",
                new[]
                {
            ("Fecha emisión:", factura.FechaEmision),
            ("Cotización Ref:", "#" + factura.IdCotizacion),
            ("Proyecto:", terreno != null ? terreno.NombreProyecto : "N/D"),
            ("Volumen:", terreno != null ? terreno.Volumen.ToString("N2") + " m³" : "N/D")
                }, fontSeccionTitulo, fontEtiqueta, fontValor, azulHeader, grisLinea);

            PdfPCell wrapperIzq = new PdfPCell(WrapEnTabla(celdaCliente)) { Border = ITextRectangle.NO_BORDER, Padding = 0, PaddingRight = 8 };
            PdfPCell wrapperDer = new PdfPCell(WrapEnTabla(celdaFactura)) { Border = ITextRectangle.NO_BORDER, Padding = 0, PaddingLeft = 8 };
            infoTable.AddCell(wrapperIzq);
            infoTable.AddCell(wrapperDer);
            doc.Add(infoTable);

            // ── TABLA DE DETALLE ───────────────────────────────────────────
            PdfPTable tablaDetalle = new PdfPTable(3) { WidthPercentage = 100, SpacingAfter = 0 };
            tablaDetalle.SetWidths(new float[] { 2.2f, 1f, 1.2f });

            string[] encabezados = { "CONCEPTO / MATERIAL", "VOLUMEN (m³)", "COSTO TOTAL" };
            int[] alinEncabezado = { Element.ALIGN_LEFT, Element.ALIGN_CENTER, Element.ALIGN_RIGHT };
            for (int i = 0; i < encabezados.Length; i++)
            {
                PdfPCell c = new PdfPCell(new Phrase(encabezados[i], fontTablaHeader));
                c.BackgroundColor = azulHeader;
                c.PaddingTop = 9;
                c.PaddingBottom = 9;
                c.PaddingLeft = 10;
                c.PaddingRight = 10;
                c.HorizontalAlignment = alinEncabezado[i];
                c.Border = ITextRectangle.NO_BORDER;
                tablaDetalle.AddCell(c);
            }

            string material = cotizacion != null ? cotizacion.Material : "N/D";
            string volumenTxt = terreno != null ? terreno.Volumen.ToString("N2") : "--";
            string costoTxt = cotizacion != null ? "$" + cotizacion.CostoTotal.ToString("N2") : "--";

            AgregarCeldaDetalle(tablaDetalle, material, fontTablaCelda, Element.ALIGN_LEFT, filaAlterna);
            AgregarCeldaDetalle(tablaDetalle, volumenTxt, fontTablaCelda, Element.ALIGN_CENTER, filaAlterna);
            AgregarCeldaDetalle(tablaDetalle, costoTxt, fontTablaCelda, Element.ALIGN_RIGHT, filaAlterna);

            doc.Add(tablaDetalle);

            // Línea inferior de cierre de la tabla
            PdfPTable cierreTabla = new PdfPTable(1) { WidthPercentage = 100, SpacingAfter = 18 };
            cierreTabla.AddCell(new PdfPCell { FixedHeight = 1.2f, BackgroundColor = grisLinea, Border = ITextRectangle.NO_BORDER });
            doc.Add(cierreTabla);

            // ── TOTAL ───────────────────────────────────────────────────
            PdfPTable totalTable = new PdfPTable(2) { WidthPercentage = 100, SpacingAfter = 30 };
            totalTable.SetWidths(new float[] { 1f, 1.4f });

            totalTable.AddCell(new PdfPCell(new Phrase("")) { Border = ITextRectangle.NO_BORDER });

            PdfPTable cajaTotal = new PdfPTable(2) { WidthPercentage = 100 };
            cajaTotal.SetWidths(new float[] { 1f, 1.3f });

            PdfPCell lblTotal = new PdfPCell(new Phrase("TOTAL A PAGAR", fontTotalLabel));
            lblTotal.BackgroundColor = doradoClaro;
            lblTotal.Padding = 12;
            lblTotal.Border = ITextRectangle.BOX;
            lblTotal.BorderColor = doradoAcento;
            lblTotal.BorderWidth = 1.2f;
            lblTotal.VerticalAlignment = Element.ALIGN_MIDDLE;
            lblTotal.NoWrap = false; // permite "TOTAL A PAGAR" en una sola línea si hay espacio suficiente

            PdfPCell valTotal = new PdfPCell(new Phrase(costoTxt, fontTotalValor));
            valTotal.BackgroundColor = doradoClaro;
            valTotal.Padding = 12;
            valTotal.Border = ITextRectangle.BOX;
            valTotal.BorderColor = doradoAcento;
            valTotal.BorderWidth = 1.2f;
            valTotal.HorizontalAlignment = Element.ALIGN_RIGHT;
            valTotal.VerticalAlignment = Element.ALIGN_MIDDLE;
            valTotal.NoWrap = true; // evita que el monto se parta en dos líneas

            cajaTotal.AddCell(lblTotal);
            cajaTotal.AddCell(valTotal);

            PdfPCell celdaCajaTotal = new PdfPCell(cajaTotal) { Border = ITextRectangle.NO_BORDER, Padding = 0 };
            totalTable.AddCell(celdaCajaTotal);
            doc.Add(totalTable);

            // ── PIE DE PÁGINA ───────────────────────────────────────────
            PdfPTable lineaPie = new PdfPTable(1) { WidthPercentage = 100, SpacingAfter = 8 };
            lineaPie.AddCell(new PdfPCell { FixedHeight = 0.8f, BackgroundColor = grisLinea, Border = ITextRectangle.NO_BORDER });
            doc.Add(lineaPie);

            Paragraph pie = new Paragraph(
                "Documento generado automáticamente por el sistema GeoIntegral. " +
                "Este documento no requiere firma ni sello para ser válido.",
                fontPie)
            { Alignment = Element.ALIGN_CENTER };
            doc.Add(pie);

            doc.Close();
            writer.Close();
        }

        // ── Resolución de ruta del logo (mismo patrón que TerrenoRepository) ───
        private string ResolveRutaLogo(string archivo)
        {
            try
            {
                var candidate1 = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Multimedia", archivo));
                var candidate2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "Multimedia", archivo));

                if (File.Exists(candidate1)) return candidate1;
                if (File.Exists(candidate2)) return candidate2;

                return candidate1;
            }
            catch
            {
                return Path.Combine("Multimedia", archivo);
            }
        }

        // ── Helpers de diseño reutilizables ─────────────────────────────

        private PdfPCell CrearCajaInfo(string titulo, (string etiqueta, string valor)[] filas,
            iTextFont fontTitulo, iTextFont fontEtiqueta, iTextFont fontValor, BaseColor colorHeader, BaseColor colorLinea)
        {
            PdfPTable contenido = new PdfPTable(1) { WidthPercentage = 100 };

            PdfPCell celdaTitulo = new PdfPCell(new Phrase(titulo, fontTitulo));
            celdaTitulo.BackgroundColor = colorHeader;
            celdaTitulo.PaddingTop = 7;
            celdaTitulo.PaddingBottom = 7;
            celdaTitulo.PaddingLeft = 10;
            celdaTitulo.Border = ITextRectangle.NO_BORDER;
            contenido.AddCell(celdaTitulo);

            for (int i = 0; i < filas.Length; i++)
            {
                var (etiqueta, valor) = filas[i];

                PdfPTable fila = new PdfPTable(2) { WidthPercentage = 100 };
                fila.SetWidths(new float[] { 1f, 1.5f });

                PdfPCell cEtq = new PdfPCell(new Phrase(etiqueta, fontEtiqueta));
                cEtq.Border = ITextRectangle.NO_BORDER;
                cEtq.PaddingTop = 7;
                cEtq.PaddingLeft = 10;
                cEtq.PaddingBottom = 7;

                PdfPCell cVal = new PdfPCell(new Phrase(valor ?? "N/D", fontValor));
                cVal.Border = ITextRectangle.NO_BORDER;
                cVal.PaddingTop = 7;
                cVal.PaddingRight = 10;
                cVal.PaddingBottom = 7;

                fila.AddCell(cEtq);
                fila.AddCell(cVal);

                PdfPCell celdaFila = new PdfPCell(fila);
                celdaFila.Border = ITextRectangle.NO_BORDER;
                celdaFila.Padding = 0;
                if (i < filas.Length - 1)
                {
                    celdaFila.BorderWidthBottom = 0.6f;
                    celdaFila.BorderColorBottom = colorLinea;
                    celdaFila.UseBorderPadding = false;
                }
                contenido.AddCell(celdaFila);
            }

            PdfPCell wrapper = new PdfPCell(contenido);
            wrapper.Border = ITextRectangle.BOX;
            wrapper.BorderColor = new BaseColor(220, 220, 220);
            wrapper.Padding = 0;
            return wrapper;
        }

        private PdfPTable WrapEnTabla(PdfPCell celda)
        {
            PdfPTable t = new PdfPTable(1) { WidthPercentage = 100 };
            t.AddCell(celda);
            return t;
        }

        private void AgregarCeldaDetalle(PdfPTable tabla, string texto, iTextFont fuente, int alineacion, BaseColor fondoFila)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.BackgroundColor = fondoFila;
            celda.PaddingTop = 10;
            celda.PaddingBottom = 10;
            celda.PaddingLeft = 10;
            celda.PaddingRight = 10;
            celda.HorizontalAlignment = alineacion;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Border = ITextRectangle.NO_BORDER;
            tabla.AddCell(celda);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
