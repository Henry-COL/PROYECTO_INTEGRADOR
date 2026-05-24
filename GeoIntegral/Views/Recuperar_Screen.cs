using GeoIntegral.Controller;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Recuperar_Screen : Form
    {
        public string rutaNotificaciones = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Notificaciones.csv"));
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
            try
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

                NotificacionController notificar = new NotificacionController();

                if (!encontrado)
                {
                    MessageBox.Show("No se encontró ninguna cuenta con ese usuario y Gmail.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    // Verificar si ya tiene una notificación pendiente
                    if (notificar.TieneNotificacionPendiente(txtUsuario.Text))
                    {
                        MessageBox.Show("Ya enviaste una solicitud al administrador. Por favor espera a que sea atendida.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Notificacion Notificacion_Registrar = new Notificacion(0, txtUsuario.Text, "Olvido de contraseña", DateTime.Today.ToString("dd/MM/yyyy"), EstadoNotificacion.Pendiente);

                    if (notificar.RegistrarNotificacion(Notificacion_Registrar))
                    {
                        MessageBox.Show("¡Notificación enviada al administrador! El equipo de soporte se pondrá en contacto con usted lo antes posible.",
                            "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al enviar la notificación al administrador.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la solicitud: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
            //    "Ingrese la nueva contraseña:",
            //    "Nueva contraseña",
            //    "");

            //if (string.IsNullOrWhiteSpace(nuevaContrasena))
            //{
            //    MessageBox.Show("La contraseña no puede estar vacía.",
            //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (control.CambiarContrasena(txtUsuario.Text, nuevaContrasena))
            //{
            //    MessageBox.Show("¡Contraseña actualizada con éxito! Ya puede iniciar sesión.",
            //        "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Ocurrió un error al actualizar la contraseña.",
            //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}