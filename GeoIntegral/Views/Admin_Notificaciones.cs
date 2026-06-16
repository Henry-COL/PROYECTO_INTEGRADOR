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
            EstilarTabla();
            CargarNotificaciones();
            CargarUsuariosEnCombo();
            CargarTodosLosUsuariosEnCombo();

            this.Shown += (s, e) =>
            {
                dgvListaUsuarios.ClearSelection();
                dgvListaUsuarios.CurrentCell = null;
            };
        }

        private void EstilarTabla()
        {
            dgvListaUsuarios.BackgroundColor = Color.FromArgb(15, 23, 33);
            dgvListaUsuarios.GridColor = Color.FromArgb(30, 45, 60);
            dgvListaUsuarios.BorderStyle = BorderStyle.None;
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToResizeRows = false;
            dgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;

            // Encabezado
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 32, 46);
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 210, 230);
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaUsuarios.ColumnHeadersHeight = 38;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Filas normales
            dgvListaUsuarios.DefaultCellStyle.BackColor = Color.FromArgb(22, 34, 48);
            dgvListaUsuarios.DefaultCellStyle.ForeColor = Color.White;
            dgvListaUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvListaUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Fila seleccionada
            dgvListaUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 16, 30);
            dgvListaUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            // Filas alternadas
            dgvListaUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 28, 40);
            dgvListaUsuarios.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 95, 80);
            dgvListaUsuarios.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvListaUsuarios.RowTemplate.Height = 32;
        }

        private void CargarNotificaciones()
        {
            dgvListaUsuarios.Rows.Clear();
            var notificaciones = notificacionController.ObtenerNotificaciones();

            foreach (var n in notificaciones)
            {
                int index = dgvListaUsuarios.Rows.Add(
                    n.IdNotificacion,
                    n.NombreUsuario,
                    n.Mensaje,
                    n.Fecha,
                    n.Estado
                );

                var fila = dgvListaUsuarios.Rows[index];
                fila.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                fila.DefaultCellStyle.ForeColor = Color.White;
                fila.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f); // ← fuerza misma fuente en toda la fila

                var celdaEstado = fila.Cells[4];
                if (n.Estado == GeoIntegral.Enums.EstadoNotificacion.Pendiente)
                    celdaEstado.Style.ForeColor = Color.FromArgb(230, 160, 40);
                else if (n.Estado == GeoIntegral.Enums.EstadoNotificacion.Leida)
                    celdaEstado.Style.ForeColor = Color.FromArgb(80, 180, 140);
            }

            // Fuerza la misma fuente en todas las columnas
            foreach (DataGridViewColumn col in dgvListaUsuarios.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CargarUsuariosEnCombo()
        {
            cmbListaUsuarios.Items.Clear();
            cmbListaUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;

            var notificaciones = notificacionController.ObtenerNotificaciones();

            foreach (var n in notificaciones)
            {
                if (n.Estado == GeoIntegral.Enums.EstadoNotificacion.Pendiente &&
                    !cmbListaUsuarios.Items.Contains(n.NombreUsuario))
                {
                    cmbListaUsuarios.Items.Add(n.NombreUsuario);
                }
            }

            cmbListaUsuarios.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya una fila seleccionada en el DataGridView
            if (dgvListaUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista en la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el nombre del usuario de la columna que corresponde (índice 1 según tu código)
            string usuarioSeleccionado = dgvListaUsuarios.SelectedRows[0].Cells[1].Value.ToString();

            // 3. Proceso de cambio de contraseña
            string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
                $"Ingrese la nueva contraseña para '{usuarioSeleccionado}':",
                "Restablecer contraseña", "");

            if (string.IsNullOrWhiteSpace(nuevaContrasena)) return;

            if (!ValidarContrasena(nuevaContrasena.Trim()))
            {
                MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, una mayúscula, un número y un carácter especial.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Ejecutar lógica
            if (usuarioController.CambiarContrasena(usuarioSeleccionado, nuevaContrasena.Trim()))
            {
                notificacionController.MarcarNotificacionPorUsuario(usuarioSeleccionado);
                MessageBox.Show($"Contraseña de '{usuarioSeleccionado}' actualizada con éxito.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar vistas
                CargarNotificaciones();
                CargarUsuariosEnCombo();
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CargarTodosLosUsuariosEnCombo()
        {
            cmbListaUsuarios.Items.Clear();
            cmbListaUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;

            // Aquí obtienes la lista total de usuarios
            // Asegúrate de que este método retorne una lista de nombres (string) o el objeto completo
            var todosLosUsuarios = usuarioController.ObtenerTodosLosUsuarios();

            foreach (var usuario in todosLosUsuarios)
            {
                cmbUsuarios.Items.Add(usuario.Nombre_Usuario);
            }

            cmbUsuarios.SelectedIndex = -1;
        }

        private void btnModificarManual_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado algo en el ComboBox
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista desplegable.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el usuario directamente del ComboBox
            string usuarioSeleccionado = cmbUsuarios.SelectedItem.ToString();

            // 3. Proceso de cambio de contraseña
            string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
                $"Ingrese la nueva contraseña para el usuario '{usuarioSeleccionado}':",
                "Modificación Manual de Contraseña", "");

            if (string.IsNullOrWhiteSpace(nuevaContrasena)) return;

            if (!ValidarContrasena(nuevaContrasena.Trim()))
            {
                MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, una mayúscula, un número y un carácter especial.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Actualizar en base de datos
            if (usuarioController.CambiarContrasena(usuarioSeleccionado, nuevaContrasena.Trim()))
            {
                MessageBox.Show($"La contraseña de '{usuarioSeleccionado}' ha sido actualizada manualmente.",
                    "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar para asegurar que los cambios se reflejen en la tabla
                CargarNotificaciones();
            }
        }
    }
}