using GeoIntegral.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Admin_Notificaciones : Form
    {
        private NotificacionController notificacionController = new NotificacionController();
        private UsuarioController usuarioController = new UsuarioController();

        public Admin_Notificaciones(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            CargarNotificaciones();
            CargarUsuariosEnCombo();
        }

        private void CargarNotificaciones()
        {
            dgvListaUsuarios.Rows.Clear();

            var notificaciones = notificacionController.ObtenerNotificaciones();

            foreach (var n in notificaciones)
            {
                dgvListaUsuarios.Rows.Add(
                    n.IdNotificacion,
                    n.NombreUsuario,
                    n.Mensaje,
                    n.Fecha,
                    n.Estado
                );
            }
        }

        private void CargarUsuariosEnCombo()
        {
            cmbListaUsuarios.Items.Clear();
            var notificaciones = notificacionController.ObtenerNotificaciones();

            foreach (var n in notificaciones)
            {
                if (n.Estado == GeoIntegral.Enums.EstadoNotificacion.Pendiente &&
                    !cmbListaUsuarios.Items.Contains(n.NombreUsuario))
                {
                    cmbListaUsuarios.Items.Add(n.NombreUsuario);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbListaUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioSeleccionado = cmbListaUsuarios.SelectedItem.ToString();

            string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
                $"Ingrese la nueva contraseña para '{usuarioSeleccionado}':",
                "Restablecer contraseña", "");

            if (string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacía.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioController.CambiarContrasena(usuarioSeleccionado, nuevaContrasena))
            {
                // Marcar la notificación del usuario como leída automáticamente
                notificacionController.MarcarNotificacionPorUsuario(usuarioSeleccionado);

                MessageBox.Show($"Contraseña de '{usuarioSeleccionado}' actualizada con éxito.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarNotificaciones();
                CargarUsuariosEnCombo();
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}