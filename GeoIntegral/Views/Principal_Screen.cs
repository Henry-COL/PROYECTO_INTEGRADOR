using GeoIntegral.Enums;
using GeoIntegral.Models;
using GeoIntegral.Repositorys;
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
                Environment.Exit(0);
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

                Admin_Panel.Visible = usuarioSesion != null && usuarioSesion.Rol == RolUsuario.Administrador;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al cargar perfil: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVentana(Form formulario, Control botonOrigen = null)
        {
            // 1. Limpiar el panel antes de añadir la nueva ventana
            Panel_Ventanas.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // 2. Usar tu interfaz ICerrable para detectar el cierre
            if (formulario is ICerrable cerrable)
            {
                cerrable.VentanaCerrada += (s, e) =>
                {
                    // Cuando la ventana avisa que se cerró, reactivamos el botón original
                    if (botonOrigen != null)
                    {
                        botonOrigen.Enabled = true;
                    }

                    // Opcional: Limpiar referencia si es necesario
                    Panel_Ventanas.Controls.Remove(formulario);
                };
            }

            // 3. Mostrar la ventana
            Panel_Ventanas.Controls.Add(formulario);
            formulario.BringToFront(); // Garantiza que se traiga al frente
            formulario.Show();

            // 4. Activar el estilo del botón (tu lógica original)
            NavegacionService.ActivarBoton(botonOrigen);
        }
        private void Panel_Ventanas_Resize(object sender, EventArgs e)
        {
            if (Panel_Ventanas.Controls.Count > 0)
            {
                Panel_Ventanas.Controls[0].Size = Panel_Ventanas.ClientSize;
                Panel_Ventanas.Controls[0].Location = new Point(0, 0);
            }
        }

        //><><>< Botones menú ><><><>//

        // -- Admin --
        private void btnAdmin_Menu_Click(object sender, EventArgs e)
        {
            btnAdmin_Menu.Enabled = false;
            CargarVentana(new Admin_Usuarios(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnAdmin_Menu2_Click(object sender, EventArgs e)
        {
            btnAdmin_Menu2.Enabled = false;
            CargarVentana(new Admin_Notificaciones(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnMenuListaClientes_Click(object sender, EventArgs e)
        {
            //CargarVentana(new Registrar_Cliente(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnMenuMateriales_Click(object sender, EventArgs e)
        {
            CargarVentana(new Usuario_Materiales(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            CargarVentana(new Usuario_Terrenos(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            CargarVentana(new Usuario_Cotizaciones(Panel_Ventanas.ClientSize), sender as Control);
        }

        // -- Perfil / Sesión --
        private void btnConfiguracion_Perfil_Click(object sender, EventArgs e)
        {
            CargarVentana(new User_Screen(usuarioSesion, Panel_Ventanas.ClientSize), sender as Control);
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
                new Login_Screen().Show();
                this.Dispose();
            }
        }

        // -- Ventana --
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

        private void btnCerrar_App_Principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Registro_Clientes_Click(object sender, EventArgs e)
        {
            CargarVentana(new Usuario_ListaClientes(Panel_Ventanas.ClientSize), sender as Control);
        }

        private void btnLista_Facturas_Click(object sender, EventArgs e)
        {
            bool esAdmin = usuarioSesion != null && usuarioSesion.Rol == RolUsuario.Administrador;
            CargarVentana(new Usuario_Facturas(Panel_Ventanas.ClientSize, esAdmin), sender as Control);
        }
        //><><>< Fin Botones ><><><>//
    }
}