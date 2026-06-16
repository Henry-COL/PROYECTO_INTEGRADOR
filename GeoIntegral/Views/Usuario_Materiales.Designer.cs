namespace GeoIntegral.Views
{
    partial class Usuario_Materiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Materiales));
            this.lblMensaje_Nombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.gbRegistrarMaterial = new System.Windows.Forms.GroupBox();
            this.numCostoUnidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreMaterial = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbListaMateriales = new System.Windows.Forms.GroupBox();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEliminarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbRegistrarMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnidad)).BeginInit();
            this.gbListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje_Nombre
            // 
            this.lblMensaje_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje_Nombre.Font = new System.Drawing.Font("Poppins", 8F);
            this.lblMensaje_Nombre.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje_Nombre.Location = new System.Drawing.Point(192, 48);
            this.lblMensaje_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_Nombre.Name = "lblMensaje_Nombre";
            this.lblMensaje_Nombre.Size = new System.Drawing.Size(206, 20);
            this.lblMensaje_Nombre.TabIndex = 2;
            this.lblMensaje_Nombre.Text = "Este material ya existe.*";
            this.lblMensaje_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins", 8F);
            this.lblNombre.Location = new System.Drawing.Point(24, 52);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 28);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Poppins", 8F);
            this.lblCosto.Location = new System.Drawing.Point(24, 133);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(61, 28);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo:";
            // 
            // gbRegistrarMaterial
            // 
            this.gbRegistrarMaterial.Controls.Add(this.lblMensaje_Nombre);
            this.gbRegistrarMaterial.Controls.Add(this.numCostoUnidad);
            this.gbRegistrarMaterial.Controls.Add(this.btnLimpiarCampos);
            this.gbRegistrarMaterial.Controls.Add(this.btnGuardarMaterial);
            this.gbRegistrarMaterial.Controls.Add(this.txtNombreMaterial);
            this.gbRegistrarMaterial.Controls.Add(this.lblNombre);
            this.gbRegistrarMaterial.Controls.Add(this.lblCosto);
            this.gbRegistrarMaterial.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbRegistrarMaterial.ForeColor = System.Drawing.SystemColors.Control;
            this.gbRegistrarMaterial.Location = new System.Drawing.Point(54, 22);
            this.gbRegistrarMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRegistrarMaterial.Name = "gbRegistrarMaterial";
            this.gbRegistrarMaterial.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRegistrarMaterial.Size = new System.Drawing.Size(692, 233);
            this.gbRegistrarMaterial.TabIndex = 8;
            this.gbRegistrarMaterial.TabStop = false;
            this.gbRegistrarMaterial.Text = "Registrar nuevo material";
            // 
            // numCostoUnidad
            // 
            this.numCostoUnidad.BackColor = System.Drawing.Color.Transparent;
            this.numCostoUnidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.numCostoUnidad.BorderRadius = 4;
            this.numCostoUnidad.BorderThickness = 2;
            this.numCostoUnidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCostoUnidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.numCostoUnidad.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.numCostoUnidad.ForeColor = System.Drawing.Color.White;
            this.numCostoUnidad.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCostoUnidad.Location = new System.Drawing.Point(29, 157);
            this.numCostoUnidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCostoUnidad.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numCostoUnidad.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCostoUnidad.Name = "numCostoUnidad";
            this.numCostoUnidad.Size = new System.Drawing.Size(369, 38);
            this.numCostoUnidad.TabIndex = 12;
            this.numCostoUnidad.ThousandsSeparator = true;
            this.numCostoUnidad.UpDownButtonFillColor = System.Drawing.Color.Chocolate;
            this.numCostoUnidad.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.btnLimpiarCampos.BorderRadius = 8;
            this.btnLimpiarCampos.BorderThickness = 4;
            this.btnLimpiarCampos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarCampos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarCampos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarCampos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarCampos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(470, 143);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(162, 45);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.btnGuardarMaterial.BorderRadius = 8;
            this.btnGuardarMaterial.BorderThickness = 4;
            this.btnGuardarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnGuardarMaterial.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnGuardarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMaterial.Location = new System.Drawing.Point(470, 77);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(162, 45);
            this.btnGuardarMaterial.TabIndex = 13;
            this.btnGuardarMaterial.Text = "Registrar";
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.txtNombreMaterial.BorderRadius = 8;
            this.txtNombreMaterial.BorderThickness = 2;
            this.txtNombreMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMaterial.DefaultText = "";
            this.txtNombreMaterial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMaterial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtNombreMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreMaterial.ForeColor = System.Drawing.Color.White;
            this.txtNombreMaterial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMaterial.Location = new System.Drawing.Point(29, 77);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.PlaceholderText = "Ingrese el nombre del material";
            this.txtNombreMaterial.SelectedText = "";
            this.txtNombreMaterial.Size = new System.Drawing.Size(369, 31);
            this.txtNombreMaterial.TabIndex = 6;
            // 
            // gbListaMateriales
            // 
            this.gbListaMateriales.Controls.Add(this.dgvMateriales);
            this.gbListaMateriales.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbListaMateriales.ForeColor = System.Drawing.SystemColors.Control;
            this.gbListaMateriales.Location = new System.Drawing.Point(28, 22);
            this.gbListaMateriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaMateriales.Name = "gbListaMateriales";
            this.gbListaMateriales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaMateriales.Size = new System.Drawing.Size(1556, 505);
            this.gbListaMateriales.TabIndex = 9;
            this.gbListaMateriales.TabStop = false;
            this.gbListaMateriales.Text = "Lista de materiales registrados";
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.CostoPorUnidad});
            this.dgvMateriales.Location = new System.Drawing.Point(15, 34);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.RowHeadersWidth = 62;
            this.dgvMateriales.Size = new System.Drawing.Size(1533, 451);
            this.dgvMateriales.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // CostoPorUnidad
            // 
            this.CostoPorUnidad.HeaderText = "Costo por Unidad";
            this.CostoPorUnidad.MinimumWidth = 8;
            this.CostoPorUnidad.Name = "CostoPorUnidad";
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
            this.btnCerrar_App.Click += new System.EventHandler(this.btnCerrar_App_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.btnEliminarMaterial);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.gbListaMateriales);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.guna2Panel1.Location = new System.Drawing.Point(18, 65);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1610, 605);
            this.guna2Panel1.TabIndex = 23;
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.btnEliminarMaterial.BorderRadius = 8;
            this.btnEliminarMaterial.BorderThickness = 4;
            this.btnEliminarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMaterial.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btnEliminarMaterial.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMaterial.Image")));
            this.btnEliminarMaterial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminarMaterial.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btnEliminarMaterial.ImageSize = new System.Drawing.Size(60, 36);
            this.btnEliminarMaterial.Location = new System.Drawing.Point(1434, 535);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(150, 51);
            this.btnEliminarMaterial.TabIndex = 24;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.TextOffset = new System.Drawing.Point(14, 2);
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(1014, 546);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecciona un material de la tabla para borrarlo. *";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 8;
            this.guna2Panel2.Controls.Add(this.gbRegistrarMaterial);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.guna2Panel2.Location = new System.Drawing.Point(399, 692);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(803, 281);
            this.guna2Panel2.TabIndex = 24;
            // 
            // Usuario_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1640, 997);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuario_Materiales";
            this.Text = "Usuario_Materiales";
            this.gbRegistrarMaterial.ResumeLayout(false);
            this.gbRegistrarMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnidad)).EndInit();
            this.gbListaMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje_Nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.GroupBox gbRegistrarMaterial;
        private System.Windows.Forms.GroupBox gbListaMateriales;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPorUnidad;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMaterial;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMaterial;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarCampos;
        private Guna.UI2.WinForms.Guna2Button btnGuardarMaterial;
        private Guna.UI2.WinForms.Guna2NumericUpDown numCostoUnidad;
    }
}