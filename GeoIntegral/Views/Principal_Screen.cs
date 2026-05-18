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
                    Admin_Panel.Visible = true;
                }
                else
                {
                    Admin_Panel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al cargar perfil: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVentana(Form formulario)
        {
            Panel_Ventanas.Resize -= Panel_Ventanas_Resize;
            Panel_Ventanas.Controls.Clear();

            // Forzar que el panel calcule su tamaño real antes de usarlo
            Panel_Ventanas.PerformLayout();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.MinimumSize = new Size(0, 0);
            formulario.MaximumSize = new Size(0, 0);

            Panel_Ventanas.Controls.Add(formulario);
            Panel_Ventanas.Tag = formulario;
            formulario.Show();

            formulario.Size = Panel_Ventanas.ClientSize;
            formulario.Location = new Point(0, 0);

            Panel_Ventanas.Resize += Panel_Ventanas_Resize;
        }

        private void Panel_Ventanas_Resize(object sender, EventArgs e)
        {
            if (Panel_Ventanas.Controls.Count > 0)
            {
                Panel_Ventanas.Controls[0].Size = Panel_Ventanas.ClientSize;
                Panel_Ventanas.Controls[0].Location = new Point(0, 0);
            }
        }

        private void btnAdmin_Menu_Click(object sender, EventArgs e)
        {
            Panel_Ventanas.PerformLayout();
            CargarVentana(new Notificaciones_Panel(Panel_Ventanas.ClientSize));
        }
    }
}