using GeoIntegral.Controller;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Registrar_Screen : Form
    {
        public Registrar_Screen()
        {
            InitializeComponent();
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar mensajes
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Gmail_.Visible = false;
                lblMensaje_Gmail_Confirmar.Visible = false;
                lblMensaje_Contrasena_.Visible = false;
                lblMensaje_Contrasena_Confirmar.Visible = false;

                bool validar = true;

                // Validar campos vacíos
                if (txtUsuario.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar = false;
                }
                if (txtGmail.Text == "")
                {
                    lblMensaje_Gmail_.Visible = true;
                    validar = false;
                }
                if (txtGmail_Confirmar.Text == "")
                {
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    validar = false;
                }
                if (txtContrasena.Text == "")
                {
                    lblMensaje_Contrasena_.Visible = true;
                    validar = false;
                }
                if (txtConfirmar_Contrasena.Text == "")
                {
                    lblMensaje_Contrasena_Confirmar.Visible = true;
                    validar = false;
                }

                if (!validar) return;

                // Validar que los Gmail coincidan
                if (txtGmail.Text != txtGmail_Confirmar.Text)
                {
                    lblMensaje_Gmail_Confirmar.Text = "Los Gmail no coinciden*";
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    return;
                }

                // Validar que las contraseñas coincidan
                if (txtContrasena.Text != txtConfirmar_Contrasena.Text)
                {
                    lblMensaje_Contrasena_Confirmar.Text = "Las contraseñas no coinciden*";
                    lblMensaje_Contrasena_Confirmar.Visible = true;
                    return;
                }

                // Validar que el usuario no exista ya
                UsuarioController control = new UsuarioController();
                if (control.UsuarioExiste(txtUsuario.Text))
                {
                    lblMensaje_Usuario.Text = "Ese usuario ya existe*";
                    lblMensaje_Usuario.Visible = true;
                    return;
                }

                // Registrar
                Usuario usuarioParaRegistrar = new Usuario(
                    txtUsuario.Text,
                    txtContrasena.Text,
                    txtGmail.Text,
                    RolUsuario.Usuario,
                    EstadoUsuario.Activo
                );

                if (control.RegistrarUsuario(usuarioParaRegistrar))
                {
                    MessageBox.Show("¡Usuario registrado con éxito!", "GeoIntegral",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuenta: " + ex.Message);
            }
        }

        private void lblIniciar_Sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
