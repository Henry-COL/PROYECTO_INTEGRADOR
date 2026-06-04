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
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.txtCostoUnidad = new System.Windows.Forms.TextBox();
            this.lblMensaje_Nombre = new System.Windows.Forms.Label();
            this.lblMensaje_Costo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnGuardarMaterial = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gbRegistrarMaterial = new System.Windows.Forms.GroupBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.gbListaMateriales = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.gbRegistrarMaterial.SuspendLayout();
            this.gbListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(69, 208);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(247, 26);
            this.txtNombreMaterial.TabIndex = 0;
            // 
            // txtCostoUnidad
            // 
            this.txtCostoUnidad.Location = new System.Drawing.Point(69, 272);
            this.txtCostoUnidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostoUnidad.Name = "txtCostoUnidad";
            this.txtCostoUnidad.Size = new System.Drawing.Size(247, 26);
            this.txtCostoUnidad.TabIndex = 1;
            // 
            // lblMensaje_Nombre
            // 
            this.lblMensaje_Nombre.AutoSize = true;
            this.lblMensaje_Nombre.Location = new System.Drawing.Point(214, 183);
            this.lblMensaje_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_Nombre.Name = "lblMensaje_Nombre";
            this.lblMensaje_Nombre.Size = new System.Drawing.Size(104, 20);
            this.lblMensaje_Nombre.TabIndex = 2;
            this.lblMensaje_Nombre.Text = "Error Nombre";
            // 
            // lblMensaje_Costo
            // 
            this.lblMensaje_Costo.AutoSize = true;
            this.lblMensaje_Costo.Location = new System.Drawing.Point(230, 248);
            this.lblMensaje_Costo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_Costo.Name = "lblMensaje_Costo";
            this.lblMensaje_Costo.Size = new System.Drawing.Size(90, 20);
            this.lblMensaje_Costo.TabIndex = 3;
            this.lblMensaje_Costo.Text = "Error Costo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 183);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(80, 248);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(55, 20);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo:";
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarMaterial.Location = new System.Drawing.Point(69, 326);
            this.btnGuardarMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(165, 35);
            this.btnGuardarMaterial.TabIndex = 6;
            this.btnGuardarMaterial.Text = "Guardar Material";
            this.btnGuardarMaterial.UseVisualStyleBackColor = true;
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(69, 371);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(165, 35);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // gbRegistrarMaterial
            // 
            this.gbRegistrarMaterial.Controls.Add(this.lblRegistro);
            this.gbRegistrarMaterial.Controls.Add(this.lblNombre);
            this.gbRegistrarMaterial.Controls.Add(this.btnLimpiarCampos);
            this.gbRegistrarMaterial.Controls.Add(this.txtNombreMaterial);
            this.gbRegistrarMaterial.Controls.Add(this.btnGuardarMaterial);
            this.gbRegistrarMaterial.Controls.Add(this.txtCostoUnidad);
            this.gbRegistrarMaterial.Controls.Add(this.lblCosto);
            this.gbRegistrarMaterial.Controls.Add(this.lblMensaje_Nombre);
            this.gbRegistrarMaterial.Controls.Add(this.lblMensaje_Costo);
            this.gbRegistrarMaterial.ForeColor = System.Drawing.SystemColors.Control;
            this.gbRegistrarMaterial.Location = new System.Drawing.Point(18, 18);
            this.gbRegistrarMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRegistrarMaterial.Name = "gbRegistrarMaterial";
            this.gbRegistrarMaterial.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRegistrarMaterial.Size = new System.Drawing.Size(396, 523);
            this.gbRegistrarMaterial.TabIndex = 8;
            this.gbRegistrarMaterial.TabStop = false;
            this.gbRegistrarMaterial.Text = "Registrar Material";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(142, 92);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(134, 20);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Registrar Material";
            // 
            // gbListaMateriales
            // 
            this.gbListaMateriales.Controls.Add(this.btnEliminarMaterial);
            this.gbListaMateriales.Controls.Add(this.dgvMateriales);
            this.gbListaMateriales.ForeColor = System.Drawing.SystemColors.Control;
            this.gbListaMateriales.Location = new System.Drawing.Point(423, 18);
            this.gbListaMateriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaMateriales.Name = "gbListaMateriales";
            this.gbListaMateriales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaMateriales.Size = new System.Drawing.Size(759, 505);
            this.gbListaMateriales.TabIndex = 9;
            this.gbListaMateriales.TabStop = false;
            this.gbListaMateriales.Text = "Lista Materiales";
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(555, 288);
            this.btnEliminarMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(160, 35);
            this.btnEliminarMaterial.TabIndex = 1;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = true;
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.CostoPorUnidad});
            this.dgvMateriales.Location = new System.Drawing.Point(10, 31);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.RowHeadersWidth = 62;
            this.dgvMateriales.Size = new System.Drawing.Size(705, 231);
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
            this.btnCerrar_App.Location = new System.Drawing.Point(1418, 12);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.PressedColor = System.Drawing.Color.Empty;
            this.btnCerrar_App.Size = new System.Drawing.Size(188, 45);
            this.btnCerrar_App.TabIndex = 19;
            this.btnCerrar_App.Text = "Volver al inicio";
            // 
            // Usuario_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1618, 941);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.gbListaMateriales);
            this.Controls.Add(this.gbRegistrarMaterial);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuario_Materiales";
            this.Text = "Usuario_Materiales";
            this.gbRegistrarMaterial.ResumeLayout(false);
            this.gbRegistrarMaterial.PerformLayout();
            this.gbListaMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.TextBox txtCostoUnidad;
        private System.Windows.Forms.Label lblMensaje_Nombre;
        private System.Windows.Forms.Label lblMensaje_Costo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnGuardarMaterial;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.GroupBox gbRegistrarMaterial;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.GroupBox gbListaMateriales;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPorUnidad;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
    }
}