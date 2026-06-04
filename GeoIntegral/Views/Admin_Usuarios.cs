using GeoIntegral.Repositorys;
using GeoIntegral.Models;
using GeoIntegral.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Admin_Usuarios : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private UsuarioRepository repo = new UsuarioRepository();

        public Admin_Usuarios(Size size)
        {
            InitializeComponent();
            this.Size = size;
            EstilarTabla();
            CargarUsuarios();

            
            this.Shown += (s, e) =>
            {
                dgvListaUsuarios.ClearSelection();
                dgvListaUsuarios.CurrentCell = null;
            };

        }

        private void CargarUsuarios()
        {
            try
            {
                dgvListaUsuarios.Rows.Clear();
                var lineas = repo.ObtenerLineas();
                foreach (var datos in lineas)
                {
                    if (datos.Length < 5) continue;
                    string usuario = datos[0]?.Trim();
                    string gmail = datos[2]?.Trim();
                    string rol = datos[3]?.Trim();
                    string estado = datos[4]?.Trim();
                    dgvListaUsuarios.Rows.Add(usuario, gmail, rol, estado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Filtrar por estado
            try
            {
                var filtro = cmbFiltro.SelectedItem?.ToString() ?? "Todos";
                dgvListaUsuarios.Rows.Clear();
                var lineas = repo.ObtenerLineas();
                foreach (var datos in lineas)
                {
                    if (datos.Length < 5) continue;
                    string estado = datos[4]?.Trim();
                    if (filtro == "Todos" || estado.Equals(filtro, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvListaUsuarios.Rows.Add(datos[0].Trim(), datos[2].Trim(), datos[3].Trim(), estado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // event handler placeholder
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2Button1_Click(sender, e);
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario primero.");
                    return;
                }

                var fila = dgvListaUsuarios.SelectedRows[0];
                string nombreUsuario = fila.Cells[0].Value?.ToString();
                string estadoActual = fila.Cells[3].Value?.ToString();
                string nuevoEstado = estadoActual.Equals("Activo", StringComparison.OrdinalIgnoreCase) ? "Inactivo" : "Activo";

                bool ok = repo.ActualizarCampo(nombreUsuario, 4, nuevoEstado);
                if (ok) CargarUsuarios();
                else MessageBox.Show("No se pudo cambiar el estado del usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message);
            }
        }
        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
        }
    }
}
