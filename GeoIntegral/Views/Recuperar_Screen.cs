using GeoIntegral.Controller;
using System;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Recuperar_Screen : Form
    {
        public Recuperar_Screen()
        {
            InitializeComponent();
        }

        private void btnCerrar_App_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNotificar_Admin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Si no ha podido recuperar su contraseña, puede enviar una notificación al administrador para solicitar ayuda. Presione Aceptar para notificar al administrador o Cancelar para intentar de nuevo.",
                "Recuperar Contraseña",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            lblMensaje_Usuario.Visible = false;
            lblMensaje_Gmail_.Visible = false;

            bool validar = true;

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

            if (!validar) return;

            UsuarioController control = new UsuarioController();
            bool encontrado = control.VerificarUsuarioYGmail(txtUsuario.Text, txtGmail.Text);

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ninguna cuenta con ese usuario y Gmail.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la nueva contraseña:",
                "Nueva contraseña",
                "");

            if (string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacía.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (control.CambiarContrasena(txtUsuario.Text, nuevaContrasena))
            {
                MessageBox.Show("¡Contraseña actualizada con éxito! Ya puede iniciar sesión.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar la contraseña.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}