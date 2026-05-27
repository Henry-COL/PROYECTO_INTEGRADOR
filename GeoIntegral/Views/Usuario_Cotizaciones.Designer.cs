namespace GeoIntegral.Views
{
    partial class Usuario_Cotizaciones
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
            this.gbDatosCotizacion = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTerreno = new System.Windows.Forms.Label();
            this.cmbMateriales = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.gbListaCotizaciones = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarCotizacion = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.IdCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosCotizacion.SuspendLayout();
            this.gbListaCotizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCotizacion
            // 
            this.gbDatosCotizacion.Controls.Add(this.lblCostoTotal);
            this.gbDatosCotizacion.Controls.Add(this.lblMaterial);
            this.gbDatosCotizacion.Controls.Add(this.cmbMateriales);
            this.gbDatosCotizacion.Controls.Add(this.lblTerreno);
            this.gbDatosCotizacion.Controls.Add(this.comboBox1);
            this.gbDatosCotizacion.Controls.Add(this.lblCliente);
            this.gbDatosCotizacion.Controls.Add(this.cmbClientes);
            this.gbDatosCotizacion.Location = new System.Drawing.Point(13, 13);
            this.gbDatosCotizacion.Name = "gbDatosCotizacion";
            this.gbDatosCotizacion.Size = new System.Drawing.Size(840, 134);
            this.gbDatosCotizacion.TabIndex = 0;
            this.gbDatosCotizacion.TabStop = false;
            this.gbDatosCotizacion.Text = "Datos Cotización";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(35, 44);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(198, 21);
            this.cmbClientes.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(32, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblTerreno
            // 
            this.lblTerreno.AutoSize = true;
            this.lblTerreno.Location = new System.Drawing.Point(265, 28);
            this.lblTerreno.Name = "lblTerreno";
            this.lblTerreno.Size = new System.Drawing.Size(47, 13);
            this.lblTerreno.TabIndex = 3;
            this.lblTerreno.Text = "Terreno:";
            // 
            // cmbMateriales
            // 
            this.cmbMateriales.FormattingEnabled = true;
            this.cmbMateriales.Location = new System.Drawing.Point(498, 44);
            this.cmbMateriales.Name = "cmbMateriales";
            this.cmbMateriales.Size = new System.Drawing.Size(198, 21);
            this.cmbMateriales.TabIndex = 4;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(495, 28);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 5;
            this.lblMaterial.Text = "Material:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(654, 99);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(90, 18);
            this.lblCostoTotal.TabIndex = 6;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // gbListaCotizaciones
            // 
            this.gbListaCotizaciones.Controls.Add(this.btnVerDetalle);
            this.gbListaCotizaciones.Controls.Add(this.btnGenerarCotizacion);
            this.gbListaCotizaciones.Controls.Add(this.dataGridView1);
            this.gbListaCotizaciones.Location = new System.Drawing.Point(13, 154);
            this.gbListaCotizaciones.Name = "gbListaCotizaciones";
            this.gbListaCotizaciones.Size = new System.Drawing.Size(840, 284);
            this.gbListaCotizaciones.TabIndex = 1;
            this.gbListaCotizaciones.TabStop = false;
            this.gbListaCotizaciones.Text = "Lista de Cotizaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCotizacion,
            this.Cliente,
            this.Terreno,
            this.Material,
            this.CostoTotal,
            this.Fecha,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGenerarCotizacion
            // 
            this.btnGenerarCotizacion.Location = new System.Drawing.Point(615, 246);
            this.btnGenerarCotizacion.Name = "btnGenerarCotizacion";
            this.btnGenerarCotizacion.Size = new System.Drawing.Size(125, 23);
            this.btnGenerarCotizacion.TabIndex = 1;
            this.btnGenerarCotizacion.Text = "Generar Cotizacion";
            this.btnGenerarCotizacion.UseVisualStyleBackColor = true;
            this.btnGenerarCotizacion.Click += new System.EventHandler(this.btnGenerarCotizacion_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(746, 246);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(88, 23);
            this.btnVerDetalle.TabIndex = 2;
            this.btnVerDetalle.Text = "Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // IdCotizacion
            // 
            this.IdCotizacion.HeaderText = "ID";
            this.IdCotizacion.Name = "IdCotizacion";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Terreno
            // 
            this.Terreno.HeaderText = "Terreno";
            this.Terreno.Name = "Terreno";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Usuario_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.gbListaCotizaciones);
            this.Controls.Add(this.gbDatosCotizacion);
            this.Name = "Usuario_Cotizaciones";
            this.Text = "cmbTerrenos";
            this.gbDatosCotizacion.ResumeLayout(false);
            this.gbDatosCotizacion.PerformLayout();
            this.gbListaCotizaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCotizacion;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMateriales;
        private System.Windows.Forms.Label lblTerreno;
        private System.Windows.Forms.GroupBox gbListaCotizaciones;
        private System.Windows.Forms.Button btnGenerarCotizacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}