using GeoIntegral.Controller;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Admin_Usuarios : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private List<Usuario> todosLosUsuarios = new List<Usuario>();

        public Admin_Usuarios(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            todosLosUsuarios = usuarioController.ObtenerTodosLosUsuarios();
            MostrarEnTabla(todosLosUsuarios);
        }

        private void MostrarEnTabla(List<Usuario> lista)
        {
            dgvUsuarios.Rows.Clear();
            foreach (var u in lista)
            {
                dgvUsuarios.Rows.Add(u.Nombre_Usuario, u.Gmail, u.Rol, u.Estado);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem == null)
            {
                MostrarEnTabla(todosLosUsuarios);
                return;
            }

            string filtro = cmbFiltro.SelectedItem.ToString();

            if (filtro == "Todos")
            {
                MostrarEnTabla(todosLosUsuarios);
            }
            else
            {
                EstadoUsuario estadoFiltro = (EstadoUsuario)Enum.Parse(typeof(EstadoUsuario), filtro);
                var filtrados = todosLosUsuarios.FindAll(u => u.Estado == estadoFiltro);
                MostrarEnTabla(filtrados);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2Button1_Click(sender, e);
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreUsuario = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
            string estadoActual = dgvUsuarios.SelectedRows[0].Cells["Estado"].Value.ToString();
            string nuevoEstado = estadoActual == "Activo" ? "Inactivo" : "Activo";

            var confirmacion = MessageBox.Show(
                $"¿Desea cambiar el estado de '{nombreUsuario}' a {nuevoEstado}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (usuarioController.CambiarEstadoUsuario(nombreUsuario, nuevoEstado))
                {
                    MessageBox.Show($"Estado de '{nombreUsuario}' cambiado a {nuevoEstado}.",
                        "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reservado para uso futuro
        }
    }
}