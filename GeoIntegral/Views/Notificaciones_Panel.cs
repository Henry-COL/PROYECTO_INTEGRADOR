using GeoIntegral.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Notificaciones_Panel : Form
    {
        private NotificacionController notificacionController = new NotificacionController();
        private UsuarioController usuarioController = new UsuarioController();

        public Notificaciones_Panel(Size tamano)
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

            var usuarios = usuarioController.ObtenerTodosLosUsuarios();

            foreach (var u in usuarios)
            {
                cmbListaUsuarios.Items.Add(u.Nombre_Usuario);
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
                // Marcar la notificación como leída si hay una seleccionada
                if (dgvListaUsuarios.SelectedRows.Count > 0)
                {
                    string idNotificacion = dgvListaUsuarios.SelectedRows[0].Cells["IDNotificacion"].Value.ToString();
                    notificacionController.MarcarComoLeida(idNotificacion);
                }

                MessageBox.Show($"Contraseña de '{usuarioSeleccionado}' actualizada con éxito.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarNotificaciones();
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}