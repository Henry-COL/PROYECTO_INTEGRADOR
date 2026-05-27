using GeoIntegral.Controller;
using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Usuario_ListaClientes : Form
    {
        private ClienteController clienteController = new ClienteController();
        private List<Cliente> todosLosClientes = new List<Cliente>();

        public Usuario_ListaClientes(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.ReadOnly = true;

            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);

            CargarClientes();
        }

        private void CargarClientes()
        {
            todosLosClientes = clienteController.ObtenerTodosLosClientes();
            MostrarEnTabla(todosLosClientes);
        }

        private void MostrarEnTabla(List<Cliente> lista)
        {
            dgvClientes.Rows.Clear();
            foreach (var c in lista)
            {
                dgvClientes.Rows.Add(c.Identificacion, c.Nombre, c.Telefono, c.Correo);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termino))
            {
                MostrarEnTabla(todosLosClientes);
                return;
            }

            var filtrados = todosLosClientes.FindAll(c =>
                c.Nombre.ToLower().Contains(termino) ||
                c.Identificacion.ToString().Contains(termino)
            );

            MostrarEnTabla(filtrados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            MostrarEnTabla(todosLosClientes);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = dgvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
            long identificacion = long.Parse(dgvClientes.SelectedRows[0].Cells["Identificacion"].Value.ToString());

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar al cliente '{nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                if (clienteController.EliminarCliente(identificacion))
                {
                    MessageBox.Show("Cliente eliminado con éxito.", "GeoIntegral",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
            }
        }
    }
}