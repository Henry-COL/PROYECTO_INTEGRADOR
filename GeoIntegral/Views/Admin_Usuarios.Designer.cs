namespace GeoIntegral.Views
{
    partial class Admin_Usuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.grp = new System.Windows.Forms.GroupBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFiltrar_Busqueda = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCambiar_Estado = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar_App = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnCerrar_App);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.guna2Panel2);
            this.panel2.Controls.Add(this.guna2Panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1640, 997);
            this.panel2.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.grp);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2Panel1.Location = new System.Drawing.Point(13, 65);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1615, 833);
            this.guna2Panel1.TabIndex = 19;
            // 
            // grp
            // 
            this.grp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp.Controls.Add(this.dgvListaUsuarios);
            this.grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.SystemColors.Window;
            this.grp.Location = new System.Drawing.Point(16, 10);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(1583, 809);
            this.grp.TabIndex = 18;
            this.grp.TabStop = false;
            this.grp.Text = "Lista de usuarios: Información";
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvListaUsuarios.Enabled = false;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(14, 31);
            this.dgvListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaUsuarios.MultiSelect = false;
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowHeadersWidth = 62;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(1555, 757);
            this.dgvListaUsuarios.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Gmail";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.cmbFiltro);
            this.guna2Panel2.Controls.Add(this.btnFiltrar_Busqueda);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2Panel2.Location = new System.Drawing.Point(346, 909);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(402, 72);
            this.guna2Panel2.TabIndex = 20;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltro.BorderRadius = 8;
            this.cmbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltro.IntegralHeight = false;
            this.cmbFiltro.ItemHeight = 30;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cmbFiltro.Location = new System.Drawing.Point(234, 18);
            this.cmbFiltro.MaxDropDownItems = 3;
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(153, 36);
            this.cmbFiltro.StartIndex = 0;
            this.cmbFiltro.TabIndex = 1;
            // 
            // btnFiltrar_Busqueda
            // 
            this.btnFiltrar_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrar_Busqueda.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnFiltrar_Busqueda.BorderRadius = 8;
            this.btnFiltrar_Busqueda.BorderThickness = 3;
            this.btnFiltrar_Busqueda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar_Busqueda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar_Busqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrar_Busqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltrar_Busqueda.FillColor = System.Drawing.Color.LimeGreen;
            this.btnFiltrar_Busqueda.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar_Busqueda.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar_Busqueda.HoverState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnFiltrar_Busqueda.Location = new System.Drawing.Point(16, 16);
            this.btnFiltrar_Busqueda.Name = "btnFiltrar_Busqueda";
            this.btnFiltrar_Busqueda.Size = new System.Drawing.Size(212, 39);
            this.btnFiltrar_Busqueda.TabIndex = 0;
            this.btnFiltrar_Busqueda.Text = "Filtrar busqueda";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.Controls.Add(this.cmbUsuario);
            this.guna2Panel3.Controls.Add(this.btnCambiar_Estado);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2Panel3.Location = new System.Drawing.Point(763, 909);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(537, 72);
            this.guna2Panel3.TabIndex = 21;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsuario.BorderRadius = 8;
            this.cmbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUsuario.ItemHeight = 30;
            this.cmbUsuario.Location = new System.Drawing.Point(233, 18);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(289, 36);
            this.cmbUsuario.TabIndex = 7;
            // 
            // btnCambiar_Estado
            // 
            this.btnCambiar_Estado.BorderColor = System.Drawing.Color.Teal;
            this.btnCambiar_Estado.BorderRadius = 8;
            this.btnCambiar_Estado.BorderThickness = 3;
            this.btnCambiar_Estado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiar_Estado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCambiar_Estado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCambiar_Estado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCambiar_Estado.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnCambiar_Estado.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCambiar_Estado.ForeColor = System.Drawing.Color.White;
            this.btnCambiar_Estado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCambiar_Estado.Location = new System.Drawing.Point(15, 16);
            this.btnCambiar_Estado.Name = "btnCambiar_Estado";
            this.btnCambiar_Estado.Size = new System.Drawing.Size(212, 39);
            this.btnCambiar_Estado.TabIndex = 6;
            this.btnCambiar_Estado.Text = "Cambiar estado";
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
            this.btnCerrar_App.TabIndex = 48;
            this.btnCerrar_App.Text = "Volver al inicio";
            this.btnCerrar_App.Click += new System.EventHandler(this.btnCerrar_App_Click);
            // 
            // Admin_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 997);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Usuarios";
            this.Text = "Menu_Admin";
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltro;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar_Busqueda;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsuario;
        private Guna.UI2.WinForms.Guna2Button btnCambiar_Estado;
        private Guna.UI2.WinForms.Guna2Button btnCerrar_App;
    }
}