using GeoIntegral.Controller;
using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Usuario_ListaClientes : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private ClienteController clienteController = new ClienteController();
        private List<Cliente> todosLosClientes = new List<Cliente>();

        public Usuario_ListaClientes(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            btnRegistrarCliente.Click += new EventHandler(btnRegistrarCliente_Click);
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

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar mensajes
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Identificacion.Visible = false;
                lblMensaje_Gmail.Visible = false;
                lblMensaje_Telefono.Visible = false;

                bool validar = true;

                // Validar campos vacíos
                if (txtNombre.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar = false;
                }
                if (txtIndentificacion.Text == "")
                {
                    lblMensaje_Identificacion.Visible = true;
                    validar = false;
                }
                if (txtGmail.Text == "")
                {
                    lblMensaje_Gmail.Visible = true;
                    validar = false;
                }
                if (txtTelefono.Text == "")
                {
                    lblMensaje_Telefono.Visible = true;
                    validar = false;
                }

                if (!validar) return;

                // Validar que la identificación sea numérica
                if (!long.TryParse(txtIndentificacion.Text, out long identificacion))
                {
                    lblMensaje_Identificacion.Text = "Solo números*";
                    lblMensaje_Identificacion.Visible = true;
                    return;
                }

                // Validar que el teléfono sea numérico
                if (!long.TryParse(txtTelefono.Text, out long _))
                {
                    lblMensaje_Telefono.Text = "Solo números*";
                    lblMensaje_Telefono.Visible = true;
                    return;
                }

                // Verificar que la identificación no esté duplicada
                ClienteController control = new ClienteController();
                if (control.ClienteExiste(identificacion))
                {
                    lblMensaje_Identificacion.Text = "Ya existe un cliente con esa identificación*";
                    lblMensaje_Identificacion.Visible = true;
                    return;
                }

                // Registrar cliente
                Cliente clienteParaRegistrar = new Cliente(
                    identificacion,
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtGmail.Text
                );

                if (control.RegistrarCliente(clienteParaRegistrar))
                {
                    MessageBox.Show("¡Cliente registrado con éxito!", "GeoIntegral",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtNombre.Text = "";
                    txtIndentificacion.Text = "";
                    txtGmail.Text = "";
                    txtTelefono.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private async void btnLimpiar_Campos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtIndentificacion.Text = "";
            txtGmail.Text = "";
            txtTelefono.Text = "";

            lblMensaje_Limpiar_Campos.Visible = true;
            await Task.Delay(1000);
            lblMensaje_Limpiar_Campos.Visible = false;
        }
    }
}