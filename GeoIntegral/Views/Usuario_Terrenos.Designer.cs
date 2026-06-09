namespace GeoIntegral.Views
{
    partial class Usuario_Terrenos
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
            this.components = new System.ComponentModel.Container();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblMensaje_Proyecto = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbCoordenadas = new System.Windows.Forms.GroupBox();
            this.gbPuntos = new System.Windows.Forms.GroupBox();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarPuntos = new System.Windows.Forms.Button();
            this.btnEliminarPunto = new System.Windows.Forms.Button();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.lblMensaje_Coordenadas = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.glControl = new OpenTK.GLControl();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.gbProyectos = new System.Windows.Forms.GroupBox();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTerreno = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbCoordenadas.SuspendLayout();
            this.gbPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblMensaje_Proyecto);
            this.gbDatos.Controls.Add(this.lblObservaciones);
            this.gbDatos.Controls.Add(this.textBox1);
            this.gbDatos.Controls.Add(this.lblNombreProyecto);
            this.gbDatos.Controls.Add(this.txtNombreProyecto);
            this.gbDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbDatos.Location = new System.Drawing.Point(13, 13);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(894, 81);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblMensaje_Proyecto
            // 
            this.lblMensaje_Proyecto.AutoSize = true;
            this.lblMensaje_Proyecto.Location = new System.Drawing.Point(220, 26);
            this.lblMensaje_Proyecto.Name = "lblMensaje_Proyecto";
            this.lblMensaje_Proyecto.Size = new System.Drawing.Size(74, 13);
            this.lblMensaje_Proyecto.TabIndex = 4;
            this.lblMensaje_Proyecto.Text = "Error Proyecto";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(478, 26);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(6, 26);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(92, 13);
            this.lblNombreProyecto.TabIndex = 1;
            this.lblNombreProyecto.Text = "Nombre Proyecto:";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(6, 42);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(288, 20);
            this.txtNombreProyecto.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbCoordenadas
            // 
            this.gbCoordenadas.Controls.Add(this.gbPuntos);
            this.gbCoordenadas.Controls.Add(this.btnLimpiarPuntos);
            this.gbCoordenadas.Controls.Add(this.btnEliminarPunto);
            this.gbCoordenadas.Controls.Add(this.btnAgregarPunto);
            this.gbCoordenadas.Controls.Add(this.lblMensaje_Coordenadas);
            this.gbCoordenadas.Controls.Add(this.lblZ);
            this.gbCoordenadas.Controls.Add(this.lblY);
            this.gbCoordenadas.Controls.Add(this.lblX);
            this.gbCoordenadas.Controls.Add(this.txtZ);
            this.gbCoordenadas.Controls.Add(this.txtY);
            this.gbCoordenadas.Controls.Add(this.txtX);
            this.gbCoordenadas.ForeColor = System.Drawing.SystemColors.Control;
            this.gbCoordenadas.Location = new System.Drawing.Point(13, 101);
            this.gbCoordenadas.Name = "gbCoordenadas";
            this.gbCoordenadas.Size = new System.Drawing.Size(528, 228);
            this.gbCoordenadas.TabIndex = 2;
            this.gbCoordenadas.TabStop = false;
            this.gbCoordenadas.Text = "Coordenadas";
            // 
            // gbPuntos
            // 
            this.gbPuntos.Controls.Add(this.dgvPuntos);
            this.gbPuntos.Location = new System.Drawing.Point(159, 19);
            this.gbPuntos.Name = "gbPuntos";
            this.gbPuntos.Size = new System.Drawing.Size(362, 197);
            this.gbPuntos.TabIndex = 11;
            this.gbPuntos.TabStop = false;
            this.gbPuntos.Text = "Puntos";
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColX,
            this.ColY,
            this.ColZ});
            this.dgvPuntos.Location = new System.Drawing.Point(6, 30);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersWidth = 62;
            this.dgvPuntos.Size = new System.Drawing.Size(350, 150);
            this.dgvPuntos.TabIndex = 10;
            // 
            // ColX
            // 
            this.ColX.HeaderText = "X";
            this.ColX.MinimumWidth = 8;
            this.ColX.Name = "ColX";
            // 
            // ColY
            // 
            this.ColY.HeaderText = "Y";
            this.ColY.MinimumWidth = 8;
            this.ColY.Name = "ColY";
            // 
            // ColZ
            // 
            this.ColZ.HeaderText = "Z";
            this.ColZ.MinimumWidth = 8;
            this.ColZ.Name = "ColZ";
            // 
            // btnLimpiarPuntos
            // 
            this.btnLimpiarPuntos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarPuntos.Location = new System.Drawing.Point(29, 176);
            this.btnLimpiarPuntos.Name = "btnLimpiarPuntos";
            this.btnLimpiarPuntos.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiarPuntos.TabIndex = 9;
            this.btnLimpiarPuntos.Text = "Limpiar Puntos";
            this.btnLimpiarPuntos.UseVisualStyleBackColor = true;
            this.btnLimpiarPuntos.Click += new System.EventHandler(this.btnLimpiarPuntos_Click);
            // 
            // btnEliminarPunto
            // 
            this.btnEliminarPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarPunto.Location = new System.Drawing.Point(29, 146);
            this.btnEliminarPunto.Name = "btnEliminarPunto";
            this.btnEliminarPunto.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarPunto.TabIndex = 8;
            this.btnEliminarPunto.Text = "Eliminar Punto";
            this.btnEliminarPunto.UseVisualStyleBackColor = true;
            this.btnEliminarPunto.Click += new System.EventHandler(this.btnEliminarPunto_Click);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPunto.Location = new System.Drawing.Point(29, 116);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarPunto.TabIndex = 7;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // lblMensaje_Coordenadas
            // 
            this.lblMensaje_Coordenadas.AutoSize = true;
            this.lblMensaje_Coordenadas.Location = new System.Drawing.Point(37, 79);
            this.lblMensaje_Coordenadas.Name = "lblMensaje_Coordenadas";
            this.lblMensaje_Coordenadas.Size = new System.Drawing.Size(95, 13);
            this.lblMensaje_Coordenadas.TabIndex = 6;
            this.lblMensaje_Coordenadas.Text = "Error Coordenadas";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(106, 27);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 13);
            this.lblZ.TabIndex = 5;
            this.lblZ.Text = "Z";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(56, 27);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(109, 43);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(44, 20);
            this.txtZ.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(59, 43);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(44, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(9, 43);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(44, 20);
            this.txtX.TabIndex = 0;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.glControl);
            this.gbResultados.Controls.Add(this.btnGuardar);
            this.gbResultados.Controls.Add(this.btnCalcular);
            this.gbResultados.Controls.Add(this.lblVolumen);
            this.gbResultados.Controls.Add(this.lblArea);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.Control;
            this.gbResultados.Location = new System.Drawing.Point(547, 100);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(635, 337);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(193, 20);
            this.glControl.Margin = new System.Windows.Forms.Padding(2);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(423, 301);
            this.glControl.TabIndex = 4;
            this.glControl.VSync = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(6, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(6, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(6, 71);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(192, 25);
            this.lblVolumen.TabIndex = 1;
            this.lblVolumen.Text = "VolumenCalculado";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(6, 28);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(153, 25);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "AreaCalculada";
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
            this.btnCerrar_App.Location = new System.Drawing.Point(945, 8);
            this.btnCerrar_App.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.PressedColor = System.Drawing.Color.Empty;
            this.btnCerrar_App.Size = new System.Drawing.Size(125, 29);
            this.btnCerrar_App.TabIndex = 19;
            this.btnCerrar_App.Text = "Volver al inicio";
            // 
            // gbProyectos
            // 
            this.gbProyectos.Controls.Add(this.btnVerTerreno);
            this.gbProyectos.Controls.Add(this.label1);
            this.gbProyectos.Controls.Add(this.cmbProyectos);
            this.gbProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbProyectos.Location = new System.Drawing.Point(13, 346);
            this.gbProyectos.Name = "gbProyectos";
            this.gbProyectos.Size = new System.Drawing.Size(273, 141);
            this.gbProyectos.TabIndex = 20;
            this.gbProyectos.TabStop = false;
            this.gbProyectos.Text = "Proyectos Guardados";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(6, 39);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(188, 21);
            this.cmbProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Proyecto:";
            // 
            // btnVerTerreno
            // 
            this.btnVerTerreno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerTerreno.Location = new System.Drawing.Point(165, 103);
            this.btnVerTerreno.Name = "btnVerTerreno";
            this.btnVerTerreno.Size = new System.Drawing.Size(97, 23);
            this.btnVerTerreno.TabIndex = 2;
            this.btnVerTerreno.Text = "Ver Terreno";
            this.btnVerTerreno.UseVisualStyleBackColor = true;
            this.btnVerTerreno.Click += new System.EventHandler(this.btnVerTerreno_Click);
            // 
            // Usuario_Terrenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.gbProyectos);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbCoordenadas);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario_Terrenos";
            this.Text = "Usuario_Terrenos";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbCoordenadas.ResumeLayout(false);
            this.gbCoordenadas.PerformLayout();
            this.gbPuntos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.gbProyectos.ResumeLayout(false);
            this.gbProyectos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMensaje_Proyecto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.GroupBox gbCoordenadas;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnLimpiarPuntos;
        private System.Windows.Forms.Button btnEliminarPunto;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Label lblMensaje_Coordenadas;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.GroupBox gbPuntos;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZ;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.GroupBox gbProyectos;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.Button btnVerTerreno;
        private System.Windows.Forms.Label label1;
    }
}