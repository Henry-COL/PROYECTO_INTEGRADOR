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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Guna2_Bordes = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 62);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 645);
            this.panel2.TabIndex = 14;
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
            this.btnCerrar_App.Location = new System.Drawing.Point(520, 8);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.Size = new System.Drawing.Size(69, 45);
            this.btnCerrar_App.TabIndex = 15;
            this.btnCerrar_App.Text = "X";
            this.btnCerrar_App.Click += new System.EventHandler(this.btnCerrar_App_Click_1);
            // 
            // Recuperar_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(601, 708);
            this.Controls.Add(this.btnCerrar_App);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperar_Screen";
            this.Text = "Recuperar_Screen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm Guna2_Bordes;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
    }
}