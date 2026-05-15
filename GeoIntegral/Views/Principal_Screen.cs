using GeoIntegral.Enums;
using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Principal_Screen : Form
    {
        private Usuario usuarioSesion;
        public Principal_Screen(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioSesion = usuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            try
            {
                if (usuarioSesion != null)
                {
                    lblNombre_Usuario.Text = usuarioSesion.Nombre_Usuario;
                    lblTipo_Usuario.Text = $"Rol: {usuarioSesion.Rol}";
                }
                else
                {
                    lblNombre_Usuario.Text = "Usuario no identificado";
                    lblTipo_Usuario.Text = "Rol: No asignado";
                }

                if (usuarioSesion != null && usuarioSesion.Rol == RolUsuario.Administrador)
                {
                    btnAdmin_Menu.Visible = true;
                }
                else
                {
                    btnAdmin_Menu.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al cargar perfil: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdmin_Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
