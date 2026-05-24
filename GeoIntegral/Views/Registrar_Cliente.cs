using GeoIntegral.Controller;
using GeoIntegral.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
            btnRegistrarCliente.Click += new EventHandler(btnRegistrarCliente_Click);
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar mensajes
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Identificacion.Visible = false;
                lblMensaje_Gmail_.Visible = false;
                lblMensaje_Gmail_Confirmar.Visible = false;
                lblMensaje_Telefono.Visible = false;

                bool validar = true;

                // Validar campos vacíos
                if (txtNombreCliente.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar = false;
                }
                if (txtIdentificacion.Text == "")
                {
                    lblMensaje_Identificacion.Visible = true;
                    validar = false;
                }
                if (txtGmail.Text == "")
                {
                    lblMensaje_Gmail_.Visible = true;
                    validar = false;
                }
                if (txtGmail_Confirmar.Text == "")
                {
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    validar = false;
                }
                if (txtTelefono.Text == "")
                {
                    lblMensaje_Telefono.Visible = true;
                    validar = false;
                }

                if (!validar) return;

                // Validar que los Gmail coincidan
                if (txtGmail.Text != txtGmail_Confirmar.Text)
                {
                    lblMensaje_Gmail_Confirmar.Text = "Los Gmail no coinciden*";
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    return;
                }

                // Validar que la identificación sea numérica
                if (!long.TryParse(txtIdentificacion.Text, out long identificacion))
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
                    txtNombreCliente.Text,
                    txtTelefono.Text,
                    txtGmail.Text
                );

                if (control.RegistrarCliente(clienteParaRegistrar))
                {
                    MessageBox.Show("¡Cliente registrado con éxito!", "GeoIntegral",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtNombreCliente.Text = "";
                    txtIdentificacion.Text = "";
                    txtGmail.Text = "";
                    txtGmail_Confirmar.Text = "";
                    txtTelefono.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}