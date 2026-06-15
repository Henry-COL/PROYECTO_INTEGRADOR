using GeoIntegral.Controller;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Registrar_Screen : Form
    {
        private readonly UsuarioController controller = new UsuarioController();
        public Registrar_Screen()
        {
            InitializeComponent();

            txtUsuario.KeyPress += TxtUsuario_KeyPress;
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Gmail_.Visible = false;
                lblMensaje_Gmail_Confirmar.Visible = false;
                lblMensaje_Contrasena_.Visible = false;
                lblMensaje_Contrasena_Confirmar.Visible = false;

                // Limpiar espacios
                txtUsuario.Text = txtUsuario.Text.Trim();
                txtGmail.Text = txtGmail.Text.Trim();
                txtGmail_Confirmar.Text = txtGmail_Confirmar.Text.Trim();

                bool validar = true;

                // Campos obligatorios
                if (txtUsuario.Text == "")
                {
                    lblMensaje_Usuario.Text = "Campo obligatorio*";
                    lblMensaje_Usuario.Visible = true;
                    validar = false;
                }

                if (txtGmail.Text == "")
                {
                    lblMensaje_Gmail_.Text = "Campo obligatorio*";
                    lblMensaje_Gmail_.Visible = true;
                    validar = false;
                }

                if (txtGmail_Confirmar.Text == "")
                {
                    lblMensaje_Gmail_Confirmar.Text = "Campo obligatorio*";
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    validar = false;
                }

                if (txtContrasena.Text == "")
                {
                    lblMensaje_Contrasena_.Text = "Campo obligatorio*";
                    lblMensaje_Contrasena_.Visible = true;
                    validar = false;
                }

                if (txtConfirmar_Contrasena.Text == "")
                {
                    lblMensaje_Contrasena_Confirmar.Text = "Campo obligatorio*";
                    lblMensaje_Contrasena_Confirmar.Visible = true;
                    validar = false;
                }

                if (!validar) return;

                // Usuario mínimo 4 caracteres
                if (txtUsuario.Text.Length < 4)
                {
                    lblMensaje_Usuario.Text = "Mínimo 4 caracteres*";
                    lblMensaje_Usuario.Visible = true;
                    return;
                }

                // Usuario sin espacios
                if (txtUsuario.Text.Contains(" "))
                {
                    lblMensaje_Usuario.Text = "No se permiten espacios*";
                    lblMensaje_Usuario.Visible = true;
                    return;
                }

                // Validar formato del correo
                try
                {
                    var correo = new System.Net.Mail.MailAddress(txtGmail.Text);
                }
                catch
                {
                    lblMensaje_Gmail_.Text = "Correo inválido*";
                    lblMensaje_Gmail_.Visible = true;
                    return;
                }

                // Confirmación de correo
                if (txtGmail.Text != txtGmail_Confirmar.Text)
                {
                    lblMensaje_Gmail_Confirmar.Text = "Los correos no coinciden*";
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    return;
                }

                // Correo duplicado
                if (controller.GmailExiste(txtGmail.Text))
                {
                    lblMensaje_Gmail_.Text = "Ese correo ya está registrado*";
                    lblMensaje_Gmail_.Visible = true;
                    return;
                }

                // Confirmación de contraseña
                if (txtContrasena.Text != txtConfirmar_Contrasena.Text)
                {
                    lblMensaje_Contrasena_Confirmar.Text = "Contraseña diferente*";
                    lblMensaje_Contrasena_Confirmar.Visible = true;
                    return;
                }

                // Seguridad de contraseña
                if (!ValidarContrasena(txtContrasena.Text))
                {
                    MessageBox.Show(
                        "La contraseña debe tener mínimo 8 caracteres, una mayúscula, un número y un carácter especial.",
                        "GeoIntegral",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblMensaje_Contrasena_.Visible = true;
                    return;
                }

                // Usuario duplicado
                if (controller.UsuarioExiste(txtUsuario.Text))
                {
                    lblMensaje_Usuario.Text = "Ese usuario ya existe*";
                    lblMensaje_Usuario.Visible = true;
                    return;
                }

                Usuario usuarioParaRegistrar = new Usuario(
                    txtUsuario.Text,
                    txtContrasena.Text,
                    txtGmail.Text,
                    RolUsuario.Usuario,
                    EstadoUsuario.Activo
                );

                if (controller.RegistrarUsuario(usuarioParaRegistrar))
                {
                    MessageBox.Show(
                        "¡Usuario registrado con éxito!",
                        "GeoIntegral",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex) when (ex.Message == "INACTIVO")
            {
                MessageBox.Show(
                    "Tu cuenta está inactiva. Contacta al administrador.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuenta: " + ex.Message);
            }
        }

        private bool ValidarContrasena(string contrasena)
        {
            if (contrasena.Length < 8) return false;

            bool tieneMayuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) tieneMayuscula = true;
                if (char.IsDigit(c)) tieneNumero = true;
                if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
            }

            return tieneMayuscula && tieneNumero && tieneEspecial;
        }

        private void lblIniciar_Sesion_Click(object sender, EventArgs e)
        {
            this.Close();
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