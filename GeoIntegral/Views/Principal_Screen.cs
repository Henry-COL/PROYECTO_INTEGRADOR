using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Principal_Screen : Form
    {
        private Usuario usuarioSesion;
        public bool CierrePorCerrarSesion { get; private set; } = false;

        public Principal_Screen(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioSesion = usuario;
            CargarDatosUsuario();
            this.FormClosed += new FormClosedEventHandler(Principal_Screen_FormClosed);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Principal_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!CierrePorCerrarSesion)
            {
                Environment.Exit(0); // Esto cierra todo el proceso //
            }
        }

        private void CargarDatosUsuario()
        {
            try
            {
                if (usuarioSesion != null)
                {
                    lblNombre_Usuario.Text = usuarioSesion.Nombre_Usuario;
                    lblTipo_Usuario.Text = $"{usuarioSesion.Rol}";
                }
                else
                {
                    lblNombre_Usuario.Text = "Usuario no identificado";
                    lblTipo_Usuario.Text = "Rol: No asignado";
                }

                if (usuarioSesion != null && usuarioSesion.Rol == RolUsuario.Administrador)
                {
                    Admin_Panel.Visible = true;
                }
                else
                {
                    Admin_Panel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al cargar perfil: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVentana(Form formulario)
        {
            Panel_Ventanas.Resize -= Panel_Ventanas_Resize;
            Panel_Ventanas.Controls.Clear();
            Panel_Ventanas.PerformLayout();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.MinimumSize = new Size(0, 0);
            formulario.MaximumSize = new Size(0, 0);

            Panel_Ventanas.Controls.Add(formulario);
            Panel_Ventanas.Tag = formulario;
            formulario.Show();

            formulario.Size = Panel_Ventanas.ClientSize;
            formulario.Location = new Point(0, 0);

            Panel_Ventanas.Resize += Panel_Ventanas_Resize;
        }

        private void Panel_Ventanas_Resize(object sender, EventArgs e)
        {
            if (Panel_Ventanas.Controls.Count > 0)
            {
                Panel_Ventanas.Controls[0].Size = Panel_Ventanas.ClientSize;
                Panel_Ventanas.Controls[0].Location = new Point(0, 0);
            }
        }

        private void btnAdmin_Menu_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            CargarVentana(new Admin_Usuarios(Panel_Ventanas.ClientSize));
        }

        private void btnAdmin_Menu2_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            foreach (Control control in Panel_Ventanas.Controls)
            {
                if (control is Admin_Notificaciones ventanaExistente)
                {
                    ventanaExistente.BringToFront();
                    return;
                }
            }
            CargarVentana(new Admin_Notificaciones(Panel_Ventanas.ClientSize));
        }

        private void btnMenuRegistrarClientes_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            foreach (Control control in Panel_Ventanas.Controls)
            {
                if (control is Registrar_Cliente ventanaExistente)
                {
                    ventanaExistente.BringToFront();
                    return;
                }
            }
            CargarVentana(new Registrar_Cliente(Panel_Ventanas.ClientSize));
        }

        private void btnConfiguracion_Perfil_Click(object sender, EventArgs e)
        {
            var perfilForm = new User_Screen(usuarioSesion, Panel_Ventanas.ClientSize);
            foreach (Control control in Panel_Ventanas.Controls)
            {
                if (control is User_Screen ventanaExistente)
                {
                    ventanaExistente.BringToFront();
                    return;
                }
            }
            CargarVentana(perfilForm);
        }

        private void btn_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                CierrePorCerrarSesion = true;

                Login_Screen login = new Login_Screen();
                login.Show();
                this.Dispose(); // Libera los recursos de esta ventana por completo
            }
        }

        private void btnMenuListaClientes_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            foreach (Control control in Panel_Ventanas.Controls)
            {
                if (control is Usuario_ListaClientes ventanaExistente)
                {
                    ventanaExistente.BringToFront();
                    return;
                }
            }
            CargarVentana(new Usuario_ListaClientes(Panel_Ventanas.ClientSize));
        }

        private void btnMenuMateriales_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            CargarVentana(new Usuario_Materiales(Panel_Ventanas.ClientSize));
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            CargarVentana(new Usuario_Terrenos(Panel_Ventanas.ClientSize));
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            CargarVentana(new Usuario_Cotizaciones(Panel_Ventanas.ClientSize));
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.StartPosition = FormStartPosition.CenterScreen;
                }
            }
        }
    }
}