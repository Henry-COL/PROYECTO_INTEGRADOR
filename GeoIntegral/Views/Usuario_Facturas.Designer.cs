namespace GeoIntegral.Views
{
    partial class Usuario_Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroCliente = new System.Windows.Forms.Label();
            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.gbTabla = new System.Windows.Forms.GroupBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.lblTotalFacturas = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.gbFiltros.SuspendLayout();
            this.gbTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnLimpiar);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Controls.Add(this.lblFiltroEstado);
            this.gbFiltros.Controls.Add(this.cmbFiltroEstado);
            this.gbFiltros.Controls.Add(this.lblHasta);
            this.gbFiltros.Controls.Add(this.lblDesde);
            this.gbFiltros.Controls.Add(this.dtpHasta);
            this.gbFiltros.Controls.Add(this.dtpDesde);
            this.gbFiltros.Controls.Add(this.lblFiltroCliente);
            this.gbFiltros.Controls.Add(this.cmbFiltroCliente);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFiltros.Location = new System.Drawing.Point(20, 20);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Size = new System.Drawing.Size(1236, 177);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(465, 128);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFiltrar.Location = new System.Drawing.Point(344, 128);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 35);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(9, 103);
            this.lblFiltroEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(103, 20);
            this.lblFiltroEstado.TabIndex = 7;
            this.lblFiltroEstado.Text = "Filtro Estado:";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(9, 128);
            this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(280, 28);
            this.cmbFiltroEstado.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(678, 42);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(339, 42);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(682, 68);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(298, 26);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(344, 68);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(298, 26);
            this.dtpDesde.TabIndex = 2;
            // 
            // lblFiltroCliente
            // 
            this.lblFiltroCliente.AutoSize = true;
            this.lblFiltroCliente.Location = new System.Drawing.Point(10, 42);
            this.lblFiltroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroCliente.Name = "lblFiltroCliente";
            this.lblFiltroCliente.Size = new System.Drawing.Size(101, 20);
            this.lblFiltroCliente.TabIndex = 1;
            this.lblFiltroCliente.Text = "Filtro Cliente:";
            // 
            // cmbFiltroCliente
            // 
            this.cmbFiltroCliente.FormattingEnabled = true;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(9, 66);
            this.cmbFiltroCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroCliente.Name = "cmbFiltroCliente";
            this.cmbFiltroCliente.Size = new System.Drawing.Size(280, 28);
            this.cmbFiltroCliente.TabIndex = 0;
            // 
            // gbTabla
            // 
            this.gbTabla.Controls.Add(this.dgvFacturas);
            this.gbTabla.ForeColor = System.Drawing.SystemColors.Control;
            this.gbTabla.Location = new System.Drawing.Point(18, 206);
            this.gbTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTabla.Name = "gbTabla";
            this.gbTabla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTabla.Size = new System.Drawing.Size(1236, 268);
            this.gbTabla.TabIndex = 1;
            this.gbTabla.TabStop = false;
            this.gbTabla.Text = "Tabla";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFactura,
            this.NombreCliente,
            this.IdCotizacion,
            this.CostoTotal,
            this.FechaEmision,
            this.Estado});
            this.dgvFacturas.Location = new System.Drawing.Point(10, 31);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidth = 62;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1216, 228);
            this.dgvFacturas.TabIndex = 0;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "N° Factura";
            this.NumeroFactura.MinimumWidth = 8;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.MinimumWidth = 8;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // IdCotizacion
            // 
            this.IdCotizacion.HeaderText = "Cotización";
            this.IdCotizacion.MinimumWidth = 8;
            this.IdCotizacion.Name = "IdCotizacion";
            this.IdCotizacion.ReadOnly = true;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.MinimumWidth = 8;
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha Emisión";
            this.FechaEmision.MinimumWidth = 8;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.lblTotalFacturas);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnCambiarEstado);
            this.pnlAcciones.Controls.Add(this.btnVerDetalle);
            this.pnlAcciones.Controls.Add(this.btnConvertir);
            this.pnlAcciones.Location = new System.Drawing.Point(20, 485);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(1234, 289);
            this.pnlAcciones.TabIndex = 2;
            // 
            // lblTotalFacturas
            // 
            this.lblTotalFacturas.AutoSize = true;
            this.lblTotalFacturas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalFacturas.Location = new System.Drawing.Point(9, 29);
            this.lblTotalFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFacturas.Name = "lblTotalFacturas";
            this.lblTotalFacturas.Size = new System.Drawing.Size(123, 20);
            this.lblTotalFacturas.TabIndex = 4;
            this.lblTotalFacturas.Text = "Total: 0 facturas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1068, 234);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Factura";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(885, 234);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(174, 35);
            this.btnCambiarEstado.TabIndex = 2;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(15, 234);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(138, 35);
            this.btnVerDetalle.TabIndex = 1;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(174, 234);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(282, 35);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir Cotización en Factura";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnCerrar_App
            // 
            this.btnCerrar_App.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar_App.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar_App.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(22)))), ((int)(((byte)(54)))));
            this.btnCerrar_App.BorderRadius = 8;
            this.btnCerrar_App.BorderThickness = 3;
            this.btnCerrar_App.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar_App.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar_App.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(87)))));
            this.btnCerrar_App.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar_App.ForeColor = System.Drawing.Color.White;
            this.btnCerrar_App.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar_App.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnCerrar_App.Location = new System.Drawing.Point(1440, 12);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.PressedColor = System.Drawing.Color.Empty;
            this.btnCerrar_App.Size = new System.Drawing.Size(188, 45);
            this.btnCerrar_App.TabIndex = 19;
            this.btnCerrar_App.Text = "Volver al inicio";
            // 
            // Usuario_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1640, 997);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbTabla);
            this.Controls.Add(this.gbFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuario_Facturas";
            this.Text = "Usuario_Facturas";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblFiltroCliente;
        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gbTabla;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblTotalFacturas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCambiarEstado;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
    }
}