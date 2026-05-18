using GeoIntegral.Models;
using System;
using System.Windows.Forms;
using GeoIntegral.Controller;

namespace GeoIntegral.Views
{
    public partial class Login_Screen : Form
    {
        private Usuario usuarioSesion;
        public Login_Screen()
        {
            InitializeComponent();
        }


        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRecuperar_Contrasena_Click(object sender, EventArgs e)
        {
            Recuperar_Screen Ventana_recuperar = new Recuperar_Screen();
            Ventana_recuperar.Show();
        }

        private void lblCrear_Cuenta_Click(object sender, EventArgs e)
        {
            var ventanaRegistrar = new Registrar_Screen();
            ventanaRegistrar.Show();
        }

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Contrasena.Visible = false;
                bool validar_inicio = true;

                if (txtUsuario.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar_inicio = false;
                }
                if (txtContrasena.Text == "")
                {
                    lblMensaje_Contrasena.Visible = true;
                    validar_inicio = false;
                }
                if (validar_inicio == true)
                {
                    UsuarioController control = new UsuarioController();
                    Usuario usuarioEncontrado = control.Autenticar(txtUsuario.Text, txtContrasena.Text);

                    if (usuarioEncontrado != null)
                    {
                        this.Hide();
                        Principal_Screen menu = new Principal_Screen(usuarioEncontrado);
                        menu.FormClosed += (s, args) => this.Close();
                        menu.Show();
                        
                    } else
                    {
                        txtContrasena.Text = "";
                        txtContrasena.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
}
