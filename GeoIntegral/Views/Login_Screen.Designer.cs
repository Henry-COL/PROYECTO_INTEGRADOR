namespace GeoIntegral.Views
{
    partial class Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciar_Sesion = new System.Windows.Forms.Button();
            this.lblRecuperar_Contraseña = new System.Windows.Forms.Label();
            this.lblCrear_Cuenta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCrear_Cuenta);
            this.panel1.Controls.Add(this.lblRecuperar_Contraseña);
            this.panel1.Controls.Add(this.btnIniciar_Sesion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(68, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 557);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GeoIntegral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(186, 297);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(304, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(186, 360);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(304, 26);
            this.txtContraseña.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(347, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Campo obligatorio*";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(347, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Campo obligatorio*";
            this.label5.Visible = false;
            // 
            // btnIniciar_Sesion
            // 
            this.btnIniciar_Sesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciar_Sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar_Sesion.Location = new System.Drawing.Point(236, 409);
            this.btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            this.btnIniciar_Sesion.Size = new System.Drawing.Size(192, 46);
            this.btnIniciar_Sesion.TabIndex = 8;
            this.btnIniciar_Sesion.Text = "Iniciar Sesión";
            this.btnIniciar_Sesion.UseVisualStyleBackColor = false;
            this.btnIniciar_Sesion.Click += new System.EventHandler(this.btnIniciar_Sesion_Click);
            // 
            // lblRecuperar_Contraseña
            // 
            this.lblRecuperar_Contraseña.AutoSize = true;
            this.lblRecuperar_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar_Contraseña.Location = new System.Drawing.Point(146, 467);
            this.lblRecuperar_Contraseña.Name = "lblRecuperar_Contraseña";
            this.lblRecuperar_Contraseña.Size = new System.Drawing.Size(171, 20);
            this.lblRecuperar_Contraseña.TabIndex = 9;
            this.lblRecuperar_Contraseña.Text = "Recuperar Contraseña";
            // 
            // lblCrear_Cuenta
            // 
            this.lblCrear_Cuenta.AutoSize = true;
            this.lblCrear_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear_Cuenta.Location = new System.Drawing.Point(335, 467);
            this.lblCrear_Cuenta.Name = "lblCrear_Cuenta";
            this.lblCrear_Cuenta.Size = new System.Drawing.Size(179, 20);
            this.lblCrear_Cuenta.TabIndex = 10;
            this.lblCrear_Cuenta.Text = "Crear una cuenta nueva";
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 637);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciar_Sesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrear_Cuenta;
        private System.Windows.Forms.Label lblRecuperar_Contraseña;
    }
}