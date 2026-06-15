using GeoIntegral.Models;
using System;
using System.Windows.Forms;
using GeoIntegral.Controller;

namespace GeoIntegral.Views
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
            // Vinculamos el evento por código para asegurar que mate el proceso al cerrar con la "X"
            this.FormClosed += new FormClosedEventHandler(Login_Screen_FormClosed);

            txtUsuario.KeyPress += TxtUsuario_KeyPress;
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Mata el proceso de raíz en el Administrador de Tareas
        }

        private void Login_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // Asegura que no quede oculto si cierran desde la "X"
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

                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    lblMensaje_Usuario.Visible = true;
                    validar_inicio = false;
                }
                if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    lblMensaje_Contrasena.Visible = true;
                    validar_inicio = false;
                }
                if (validar_inicio == true)
                {
                    UsuarioController control = new UsuarioController();
                    txtUsuario.Text = txtUsuario.Text.Trim();
                    Usuario usuarioEncontrado = control.Autenticar(txtUsuario.Text, txtContrasena.Text);

                    if (usuarioEncontrado != null)
                    {
                        this.Hide();
                        Principal_Screen menu = new Principal_Screen(usuarioEncontrado);
                        menu.Show();
                    }
                    else
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

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '_' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}