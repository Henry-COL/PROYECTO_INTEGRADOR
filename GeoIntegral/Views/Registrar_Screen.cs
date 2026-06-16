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
            // Reiniciar mensajes
            lblMensaje_Usuario.Visible = false;
            lblMensaje_Gmail_.Visible = false;
            lblMensaje_Gmail_Confirmar.Visible = false;
            lblMensaje_Contrasena_.Visible = false;
            lblMensaje_Contrasena_Confirmar.Visible = false;

            // Validación de presentación pura: campos vacíos
            bool hayVacios = false;

            if (txtUsuario.Text.Trim() == "") { lblMensaje_Usuario.Visible = true; hayVacios = true; }
            if (txtGmail.Text.Trim() == "") { lblMensaje_Gmail_.Visible = true; hayVacios = true; }
            if (txtGmail_Confirmar.Text.Trim() == "") { lblMensaje_Gmail_Confirmar.Visible = true; hayVacios = true; }
            if (txtContrasena.Text == "") { lblMensaje_Contrasena_.Visible = true; hayVacios = true; }
            if (txtConfirmar_Contrasena.Text == "") { lblMensaje_Contrasena_Confirmar.Visible = true; hayVacios = true; }

            if (hayVacios) return;
            try
            {
                Usuario nuevoUsuario = new Usuario(txtUsuario.Text.Trim(), txtContrasena.Text, txtGmail.Text.Trim(), RolUsuario.Usuario, EstadoUsuario.Activo);

                if (controller.RegistrarUsuario(nuevoUsuario, txtGmail_Confirmar.Text.Trim(), txtConfirmar_Contrasena.Text))
                {
                    MessageBox.Show("¡Usuario registrado con éxito!", "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnVer1_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            txtConfirmar_Contrasena.UseSystemPasswordChar = !txtConfirmar_Contrasena.UseSystemPasswordChar;
        }
    }
}