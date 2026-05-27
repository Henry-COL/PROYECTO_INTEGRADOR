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
            this.gbRegistrarMaterial.SuspendLayout();
            this.gbListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(46, 135);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(166, 20);
            this.txtNombreMaterial.TabIndex = 0;
            // 
            // txtCostoUnidad
            // 
            this.txtCostoUnidad.Location = new System.Drawing.Point(46, 177);
            this.txtCostoUnidad.Name = "txtCostoUnidad";
            this.txtCostoUnidad.Size = new System.Drawing.Size(166, 20);
            this.txtCostoUnidad.TabIndex = 1;
            // 
            // lblMensaje_Nombre
            // 
            this.lblMensaje_Nombre.AutoSize = true;
            this.lblMensaje_Nombre.Location = new System.Drawing.Point(143, 119);
            this.lblMensaje_Nombre.Name = "lblMensaje_Nombre";
            this.lblMensaje_Nombre.Size = new System.Drawing.Size(69, 13);
            this.lblMensaje_Nombre.TabIndex = 2;
            this.lblMensaje_Nombre.Text = "Error Nombre";
            // 
            // lblMensaje_Costo
            // 
            this.lblMensaje_Costo.AutoSize = true;
            this.lblMensaje_Costo.Location = new System.Drawing.Point(153, 161);
            this.lblMensaje_Costo.Name = "lblMensaje_Costo";
            this.lblMensaje_Costo.Size = new System.Drawing.Size(59, 13);
            this.lblMensaje_Costo.TabIndex = 3;
            this.lblMensaje_Costo.Text = "Error Costo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(53, 161);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo:";
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.Location = new System.Drawing.Point(46, 212);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(110, 23);
            this.btnGuardarMaterial.TabIndex = 6;
            this.btnGuardarMaterial.Text = "Guardar Material";
            this.btnGuardarMaterial.UseVisualStyleBackColor = true;
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(46, 241);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(110, 23);
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
            this.gbRegistrarMaterial.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarMaterial.Name = "gbRegistrarMaterial";
            this.gbRegistrarMaterial.Size = new System.Drawing.Size(264, 340);
            this.gbRegistrarMaterial.TabIndex = 8;
            this.gbRegistrarMaterial.TabStop = false;
            this.gbRegistrarMaterial.Text = "Registrar Material";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(95, 60);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(89, 13);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Registrar Material";
            // 
            // gbListaMateriales
            // 
            this.gbListaMateriales.Controls.Add(this.btnEliminarMaterial);
            this.gbListaMateriales.Controls.Add(this.dgvMateriales);
            this.gbListaMateriales.Location = new System.Drawing.Point(282, 12);
            this.gbListaMateriales.Name = "gbListaMateriales";
            this.gbListaMateriales.Size = new System.Drawing.Size(506, 328);
            this.gbListaMateriales.TabIndex = 9;
            this.gbListaMateriales.TabStop = false;
            this.gbListaMateriales.Text = "Lista Materiales";
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.Location = new System.Drawing.Point(370, 187);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(107, 23);
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
            this.dgvMateriales.Location = new System.Drawing.Point(7, 20);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.Size = new System.Drawing.Size(470, 150);
            this.dgvMateriales.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // CostoPorUnidad
            // 
            this.CostoPorUnidad.HeaderText = "Costo por Unidad";
            this.CostoPorUnidad.Name = "CostoPorUnidad";
            // 
            // Usuario_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbListaMateriales);
            this.Controls.Add(this.gbRegistrarMaterial);
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
    }
}