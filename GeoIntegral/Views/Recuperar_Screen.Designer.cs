namespace GeoIntegral.Views
{
    partial class Recuperar_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Guna2_Bordes = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje_Gmail_ = new System.Windows.Forms.Label();
            this.lblNotificar_Admin = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecuperarContraseña = new Guna.UI2.WinForms.Guna2Button();
            this.lblMensaje_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 62);
            this.panel1.TabIndex = 13;
            // 
            // Guna2_Bordes
            // 
            this.Guna2_Bordes.BorderRadius = 14;
            this.Guna2_Bordes.ContainerControl = this;
            this.Guna2_Bordes.DockIndicatorTransparencyValue = 0.6D;
            this.Guna2_Bordes.TransparentWhileDrag = true;
            // 
            // btnCerrar_App
            // 
            this.btnCerrar_App.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.btnCerrar_App.BorderRadius = 8;
            this.btnCerrar_App.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar_App.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar_App.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.btnCerrar_App.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_App.ForeColor = System.Drawing.Color.White;
            this.btnCerrar_App.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnCerrar_App.Location = new System.Drawing.Point(566, 8);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.Size = new System.Drawing.Size(69, 45);
            this.btnCerrar_App.TabIndex = 15;
            this.btnCerrar_App.Text = "X";
            this.btnCerrar_App.Click += new System.EventHandler(this.btnCerrar_App_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GeoIntegral.Properties.Resources.App_Recuperar_Wallpaper;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 582);
            this.panel2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins", 7F);
            this.label11.ForeColor = System.Drawing.Color.Khaki;
            this.label11.Location = new System.Drawing.Point(49, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Para poder restaurar tu contraseña, comparte la información que se te pide.";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.txtGmail);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.lblMensaje_Gmail_);
            this.guna2Panel1.Controls.Add(this.lblNotificar_Admin);
            this.guna2Panel1.Controls.Add(this.txtUsuario);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnRecuperarContraseña);
            this.guna2Panel1.Controls.Add(this.lblMensaje_Usuario);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.guna2Panel1.Location = new System.Drawing.Point(67, 181);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(512, 282);
            this.guna2Panel1.TabIndex = 30;
            // 
            // txtGmail
            // 
            this.txtGmail.BorderRadius = 4;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.DefaultText = "";
            this.txtGmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGmail.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGmail.Location = new System.Drawing.Point(39, 115);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGmail.PlaceholderText = "Ingrece una cuenta de Gmail.";
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(435, 28);
            this.txtGmail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gmail:";
            // 
            // lblMensaje_Gmail_
            // 
            this.lblMensaje_Gmail_.AutoSize = true;
            this.lblMensaje_Gmail_.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje_Gmail_.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje_Gmail_.Location = new System.Drawing.Point(279, 86);
            this.lblMensaje_Gmail_.Name = "lblMensaje_Gmail_";
            this.lblMensaje_Gmail_.Size = new System.Drawing.Size(195, 31);
            this.lblMensaje_Gmail_.TabIndex = 30;
            this.lblMensaje_Gmail_.Text = "Campo obligatorio*";
            this.lblMensaje_Gmail_.Visible = false;
            // 
            // lblNotificar_Admin
            // 
            this.lblNotificar_Admin.AutoSize = true;
            this.lblNotificar_Admin.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificar_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotificar_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificar_Admin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificar_Admin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotificar_Admin.Location = new System.Drawing.Point(117, 226);
            this.lblNotificar_Admin.Name = "lblNotificar_Admin";
            this.lblNotificar_Admin.Size = new System.Drawing.Size(292, 31);
            this.lblNotificar_Admin.TabIndex = 26;
            this.lblNotificar_Admin.Text = "Deja una notificación al admin";
            this.lblNotificar_Admin.Click += new System.EventHandler(this.lblNotificar_Admin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderRadius = 4;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(39, 50);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "Ingrese su nombre de usuario.";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(435, 28);
            this.txtUsuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de usuario:";
            // 
            // btnRecuperarContraseña
            // 
            this.btnRecuperarContraseña.BorderRadius = 7;
            this.btnRecuperarContraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecuperarContraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecuperarContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecuperarContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecuperarContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnRecuperarContraseña.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarContraseña.Location = new System.Drawing.Point(126, 169);
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.Size = new System.Drawing.Size(264, 45);
            this.btnRecuperarContraseña.TabIndex = 16;
            this.btnRecuperarContraseña.Text = "Recuperar Contraseña";
            // 
            // lblMensaje_Usuario
            // 
            this.lblMensaje_Usuario.AutoSize = true;
            this.lblMensaje_Usuario.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje_Usuario.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje_Usuario.Location = new System.Drawing.Point(279, 21);
            this.lblMensaje_Usuario.Name = "lblMensaje_Usuario";
            this.lblMensaje_Usuario.Size = new System.Drawing.Size(195, 31);
            this.lblMensaje_Usuario.TabIndex = 14;
            this.lblMensaje_Usuario.Text = "Campo obligatorio*";
            this.lblMensaje_Usuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 92);
            this.label1.TabIndex = 29;
            this.label1.Text = "Soporte Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GeoIntegral.Properties.Resources.GeoIntegral_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GeoIntegral.Properties.Resources.GeoIntegral_LogoTipo;
            this.pictureBox2.Location = new System.Drawing.Point(54, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Recuperar_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(648, 645);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recuperar_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte Contraseña";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm Guna2_Bordes;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtGmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensaje_Gmail_;
        private System.Windows.Forms.Label lblNotificar_Admin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRecuperarContraseña;
        private System.Windows.Forms.Label lblMensaje_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}