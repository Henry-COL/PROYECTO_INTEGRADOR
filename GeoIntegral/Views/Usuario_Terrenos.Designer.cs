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
            this.lblNombreProyecto = new System.Windows.Forms.Label();
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
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.glControl = new OpenTK.GLControl();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.gbProyectos = new System.Windows.Forms.GroupBox();
            this.btnVerTerreno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVerDetalle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreProyecto = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtY = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtX = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtZ = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDatos.SuspendLayout();
            this.gbCoordenadas.SuspendLayout();
            this.gbPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbProyectos.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.textBox1);
            this.gbDatos.Controls.Add(this.txtNombreProyecto);
            this.gbDatos.Controls.Add(this.lblMensaje_Proyecto);
            this.gbDatos.Controls.Add(this.lblObservaciones);
            this.gbDatos.Controls.Add(this.lblNombreProyecto);
            this.gbDatos.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbDatos.Location = new System.Drawing.Point(23, 27);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatos.Size = new System.Drawing.Size(616, 199);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblMensaje_Proyecto
            // 
            this.lblMensaje_Proyecto.AutoSize = true;
            this.lblMensaje_Proyecto.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje_Proyecto.Location = new System.Drawing.Point(278, 40);
            this.lblMensaje_Proyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_Proyecto.Name = "lblMensaje_Proyecto";
            this.lblMensaje_Proyecto.Size = new System.Drawing.Size(128, 28);
            this.lblMensaje_Proyecto.TabIndex = 4;
            this.lblMensaje_Proyecto.Text = "Error Proyecto";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.lblObservaciones.Location = new System.Drawing.Point(9, 121);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(138, 28);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.lblNombreProyecto.Location = new System.Drawing.Point(9, 40);
            this.lblNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(157, 28);
            this.lblNombreProyecto.TabIndex = 1;
            this.lblNombreProyecto.Text = "Nombre Proyecto:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbCoordenadas
            // 
            this.gbCoordenadas.Controls.Add(this.txtZ);
            this.gbCoordenadas.Controls.Add(this.gbProyectos);
            this.gbCoordenadas.Controls.Add(this.txtX);
            this.gbCoordenadas.Controls.Add(this.txtY);
            this.gbCoordenadas.Controls.Add(this.btnLimpiarPuntos);
            this.gbCoordenadas.Controls.Add(this.gbPuntos);
            this.gbCoordenadas.Controls.Add(this.btnEliminarPunto);
            this.gbCoordenadas.Controls.Add(this.btnAgregarPunto);
            this.gbCoordenadas.Controls.Add(this.lblMensaje_Coordenadas);
            this.gbCoordenadas.Controls.Add(this.lblZ);
            this.gbCoordenadas.Controls.Add(this.lblY);
            this.gbCoordenadas.Controls.Add(this.lblX);
            this.gbCoordenadas.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbCoordenadas.ForeColor = System.Drawing.SystemColors.Control;
            this.gbCoordenadas.Location = new System.Drawing.Point(26, 20);
            this.gbCoordenadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCoordenadas.Name = "gbCoordenadas";
            this.gbCoordenadas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCoordenadas.Size = new System.Drawing.Size(534, 804);
            this.gbCoordenadas.TabIndex = 2;
            this.gbCoordenadas.TabStop = false;
            this.gbCoordenadas.Text = "Coordenadas";
            // 
            // gbPuntos
            // 
            this.gbPuntos.BackColor = System.Drawing.Color.Transparent;
            this.gbPuntos.Controls.Add(this.dgvPuntos);
            this.gbPuntos.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbPuntos.ForeColor = System.Drawing.Color.White;
            this.gbPuntos.Location = new System.Drawing.Point(21, 190);
            this.gbPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPuntos.Name = "gbPuntos";
            this.gbPuntos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPuntos.Size = new System.Drawing.Size(460, 303);
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
            this.dgvPuntos.Location = new System.Drawing.Point(9, 32);
            this.dgvPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersWidth = 62;
            this.dgvPuntos.Size = new System.Drawing.Size(438, 261);
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
            this.btnLimpiarPuntos.Location = new System.Drawing.Point(345, 98);
            this.btnLimpiarPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarPuntos.Name = "btnLimpiarPuntos";
            this.btnLimpiarPuntos.Size = new System.Drawing.Size(155, 35);
            this.btnLimpiarPuntos.TabIndex = 9;
            this.btnLimpiarPuntos.Text = "Limpiar Puntos";
            this.btnLimpiarPuntos.UseVisualStyleBackColor = true;
            this.btnLimpiarPuntos.Click += new System.EventHandler(this.btnLimpiarPuntos_Click);
            // 
            // btnEliminarPunto
            // 
            this.btnEliminarPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarPunto.Location = new System.Drawing.Point(175, 98);
            this.btnEliminarPunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPunto.Name = "btnEliminarPunto";
            this.btnEliminarPunto.Size = new System.Drawing.Size(154, 35);
            this.btnEliminarPunto.TabIndex = 8;
            this.btnEliminarPunto.Text = "Eliminar Punto";
            this.btnEliminarPunto.UseVisualStyleBackColor = true;
            this.btnEliminarPunto.Click += new System.EventHandler(this.btnEliminarPunto_Click);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPunto.Location = new System.Drawing.Point(8, 98);
            this.btnAgregarPunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(154, 35);
            this.btnAgregarPunto.TabIndex = 7;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // lblMensaje_Coordenadas
            // 
            this.lblMensaje_Coordenadas.AutoSize = true;
            this.lblMensaje_Coordenadas.Location = new System.Drawing.Point(146, 153);
            this.lblMensaje_Coordenadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_Coordenadas.Name = "lblMensaje_Coordenadas";
            this.lblMensaje_Coordenadas.Size = new System.Drawing.Size(168, 28);
            this.lblMensaje_Coordenadas.TabIndex = 6;
            this.lblMensaje_Coordenadas.Text = "Error Coordenadas";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblZ.Location = new System.Drawing.Point(287, 41);
            this.lblZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(27, 28);
            this.lblZ.TabIndex = 5;
            this.lblZ.Text = "Z:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblY.Location = new System.Drawing.Point(150, 41);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(28, 28);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.Crimson;
            this.lblX.Location = new System.Drawing.Point(15, 42);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(28, 28);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.groupBox1);
            this.gbResultados.Controls.Add(this.btnGuardar);
            this.gbResultados.Controls.Add(this.btnCalcular);
            this.gbResultados.Controls.Add(this.lblVolumen);
            this.gbResultados.Controls.Add(this.lblArea);
            this.gbResultados.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbResultados.ForeColor = System.Drawing.SystemColors.Control;
            this.gbResultados.Location = new System.Drawing.Point(23, 32);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbResultados.Size = new System.Drawing.Size(798, 727);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(27, 31);
            this.glControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(613, 432);
            this.glControl.TabIndex = 4;
            this.glControl.VSync = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(362, 118);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(362, 72);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(9, 109);
            this.lblVolumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(287, 37);
            this.lblVolumen.TabIndex = 1;
            this.lblVolumen.Text = "VolumenCalculado";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(9, 43);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(228, 37);
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
            this.btnCerrar_App.Location = new System.Drawing.Point(1672, 12);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.PressedColor = System.Drawing.Color.Empty;
            this.btnCerrar_App.Size = new System.Drawing.Size(188, 45);
            this.btnCerrar_App.TabIndex = 19;
            this.btnCerrar_App.Text = "Volver al inicio";
            // 
            // gbProyectos
            // 
            this.gbProyectos.Controls.Add(this.btnVerTerreno);
            this.gbProyectos.Controls.Add(this.label1);
            this.gbProyectos.Controls.Add(this.cmbProyectos);
            this.gbProyectos.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.gbProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbProyectos.Location = new System.Drawing.Point(21, 534);
            this.gbProyectos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProyectos.Name = "gbProyectos";
            this.gbProyectos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProyectos.Size = new System.Drawing.Size(410, 217);
            this.gbProyectos.TabIndex = 20;
            this.gbProyectos.TabStop = false;
            this.gbProyectos.Text = "Proyectos Guardados";
            // 
            // btnVerTerreno
            // 
            this.btnVerTerreno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerTerreno.Location = new System.Drawing.Point(78, 143);
            this.btnVerTerreno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerTerreno.Name = "btnVerTerreno";
            this.btnVerTerreno.Size = new System.Drawing.Size(146, 35);
            this.btnVerTerreno.TabIndex = 2;
            this.btnVerTerreno.Text = "Ver Terreno";
            this.btnVerTerreno.UseVisualStyleBackColor = true;
            this.btnVerTerreno.Click += new System.EventHandler(this.btnVerTerreno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Proyecto:";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(20, 84);
            this.cmbProyectos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(280, 36);
            this.cmbProyectos.TabIndex = 0;
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
            this.guna2Panel1.Controls.Add(this.btnVerDetalle);
            this.guna2Panel1.Controls.Add(this.gbCoordenadas);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.guna2Panel1.Location = new System.Drawing.Point(28, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(589, 854);
            this.guna2Panel1.TabIndex = 23;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.btnVerDetalle.BorderRadius = 8;
            this.btnVerDetalle.BorderThickness = 4;
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerDetalle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerDetalle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnVerDetalle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalle.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnVerDetalle.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnVerDetalle.Image = global::GeoIntegral.Properties.Resources.App_Detalles;
            this.btnVerDetalle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVerDetalle.ImageOffset = new System.Drawing.Point(-19, 0);
            this.btnVerDetalle.ImageSize = new System.Drawing.Size(80, 62);
            this.btnVerDetalle.Location = new System.Drawing.Point(1404, 477);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(184, 51);
            this.btnVerDetalle.TabIndex = 12;
            this.btnVerDetalle.Text = "Ver detalles";
            this.btnVerDetalle.TextOffset = new System.Drawing.Point(20, 2);
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
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.gbResultados);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.guna2Panel2.Location = new System.Drawing.Point(623, 333);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(872, 784);
            this.guna2Panel2.TabIndex = 24;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 4;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.Image = global::GeoIntegral.Properties.Resources.App_Detalles;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-19, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(80, 62);
            this.guna2Button1.Location = new System.Drawing.Point(1404, 477);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(184, 51);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Ver detalles";
            this.guna2Button1.TextOffset = new System.Drawing.Point(20, 2);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(74)))));
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.BorderThickness = 8;
            this.guna2Panel3.Controls.Add(this.guna2Button2);
            this.guna2Panel3.Controls.Add(this.gbDatos);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.guna2Panel3.Location = new System.Drawing.Point(609, 73);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(662, 254);
            this.guna2Panel3.TabIndex = 25;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.BorderThickness = 4;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.guna2Button2.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Orange;
            this.guna2Button2.Image = global::GeoIntegral.Properties.Resources.App_Detalles;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(-19, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(80, 62);
            this.guna2Button2.Location = new System.Drawing.Point(1404, 477);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(184, 51);
            this.guna2Button2.TabIndex = 12;
            this.guna2Button2.Text = "Ver detalles";
            this.guna2Button2.TextOffset = new System.Drawing.Point(20, 2);
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.txtNombreProyecto.BorderRadius = 4;
            this.txtNombreProyecto.BorderThickness = 3;
            this.txtNombreProyecto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProyecto.DefaultText = "";
            this.txtNombreProyecto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProyecto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProyecto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProyecto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProyecto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtNombreProyecto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProyecto.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.txtNombreProyecto.ForeColor = System.Drawing.Color.White;
            this.txtNombreProyecto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProyecto.Location = new System.Drawing.Point(14, 65);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.txtNombreProyecto.PlaceholderText = "Ingresa el nombre del proyecto.";
            this.txtNombreProyecto.SelectedText = "";
            this.txtNombreProyecto.Size = new System.Drawing.Size(518, 36);
            this.txtNombreProyecto.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.textBox1.BorderRadius = 5;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(14, 146);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.textBox1.PlaceholderText = "Ingrese alguna observación.";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(518, 36);
            this.textBox1.TabIndex = 6;
            // 
            // txtY
            // 
            this.txtY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.txtY.BorderRadius = 4;
            this.txtY.BorderThickness = 3;
            this.txtY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtY.DefaultText = "";
            this.txtY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtY.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.txtY.ForeColor = System.Drawing.Color.White;
            this.txtY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtY.Location = new System.Drawing.Point(175, 34);
            this.txtY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtY.Name = "txtY";
            this.txtY.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.txtY.PlaceholderText = "Ej; 1";
            this.txtY.SelectedText = "";
            this.txtY.Size = new System.Drawing.Size(94, 36);
            this.txtY.TabIndex = 7;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX
            // 
            this.txtX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.txtX.BorderRadius = 4;
            this.txtX.BorderThickness = 3;
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.DefaultText = "";
            this.txtX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.txtX.ForeColor = System.Drawing.Color.White;
            this.txtX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX.Location = new System.Drawing.Point(41, 34);
            this.txtX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtX.Name = "txtX";
            this.txtX.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.txtX.PlaceholderText = "Ej; 1";
            this.txtX.SelectedText = "";
            this.txtX.Size = new System.Drawing.Size(94, 36);
            this.txtX.TabIndex = 12;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZ
            // 
            this.txtZ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.txtZ.BorderRadius = 4;
            this.txtZ.BorderThickness = 3;
            this.txtZ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZ.DefaultText = "";
            this.txtZ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtZ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtZ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtZ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtZ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtZ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtZ.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.txtZ.ForeColor = System.Drawing.Color.White;
            this.txtZ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtZ.Location = new System.Drawing.Point(311, 34);
            this.txtZ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtZ.Name = "txtZ";
            this.txtZ.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(150)))), ((int)(((byte)(185)))));
            this.txtZ.PlaceholderText = "Ej; 1";
            this.txtZ.SelectedText = "";
            this.txtZ.Size = new System.Drawing.Size(94, 36);
            this.txtZ.TabIndex = 13;
            this.txtZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glControl);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(26, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(647, 478);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfica";
            // 
            // Usuario_Terrenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1640, 997);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMensaje_Proyecto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.GroupBox gbCoordenadas;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnVerDetalle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProyecto;
        private Guna.UI2.WinForms.Guna2TextBox txtZ;
        private Guna.UI2.WinForms.Guna2TextBox txtX;
        private Guna.UI2.WinForms.Guna2TextBox txtY;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}