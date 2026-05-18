namespace GeoIntegral.Views
{
    partial class Notificaciones_Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbListaUsuarios = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.cmbListaUsuarios);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.grp);
            this.panel1.Controls.Add(this.btnCerrar_App);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1616, 906);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 691);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar_App
            // 
            this.btnCerrar_App.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar_App.BorderRadius = 8;
            this.btnCerrar_App.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar_App.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar_App.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar_App.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar_App.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_App.ForeColor = System.Drawing.Color.White;
            this.btnCerrar_App.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnCerrar_App.Location = new System.Drawing.Point(951, 12);
            this.btnCerrar_App.Name = "btnCerrar_App";
            this.btnCerrar_App.Size = new System.Drawing.Size(176, 45);
            this.btnCerrar_App.TabIndex = 16;
            this.btnCerrar_App.Text = "Volver al inicio";
            this.btnCerrar_App.Click += new System.EventHandler(this.btnCerrar_App_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.dgvListaUsuarios);
            this.grp.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.SystemColors.Window;
            this.grp.Location = new System.Drawing.Point(25, 73);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(1086, 509);
            this.grp.TabIndex = 17;
            this.grp.TabStop = false;
            this.grp.Text = "Lista de notificación: Restaurar contraseñas";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 7;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(81)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(881, 593);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 45);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar contraseña";
            // 
            // cmbListaUsuarios
            // 
            this.cmbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.cmbListaUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbListaUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaUsuarios.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbListaUsuarios.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbListaUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbListaUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbListaUsuarios.ItemHeight = 30;
            this.cmbListaUsuarios.Location = new System.Drawing.Point(586, 599);
            this.cmbListaUsuarios.Name = "cmbListaUsuarios";
            this.cmbListaUsuarios.Size = new System.Drawing.Size(289, 36);
            this.cmbListaUsuarios.TabIndex = 19;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(13, 30);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowHeadersWidth = 62;
            this.dgvListaUsuarios.RowTemplate.Height = 28;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(1057, 448);
            this.dgvListaUsuarios.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl.Location = new System.Drawing.Point(391, 603);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(189, 28);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "Nombre de usuario:";
            // 
            // Notificaciones_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1145, 691);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1638, 906);
            this.MinimumSize = new System.Drawing.Size(1145, 667);
            this.Name = "Notificaciones_Panel";
            this.Text = "Notificaciones_Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
        private System.Windows.Forms.GroupBox grp;
        private Guna.UI2.WinForms.Guna2ComboBox cmbListaUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Label lbl;
    }
}