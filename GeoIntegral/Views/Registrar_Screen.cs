using GeoIntegral.Controller;
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
    public partial class Registrar_Screen : Form
    {
        public Registrar_Screen()
        {
            InitializeComponent();
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Gmail_.Visible = false;
                lblMensaje_Gmail_Confirmar.Visible = false;
                lblMensaje_Contrasena_.Visible = false;
                lblMensaje_Contrasena_Confirmar.Visible = false;
                bool validar_inicio = true;

                if (txtUsuario.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar_inicio = false;
                }
                if (txtGmail.Text == "")
                {
                    lblMensaje_Gmail_.Visible = true;
                    validar_inicio = false;
                }
                if (txtGmail_Confirmar.Text == "")
                {
                    lblMensaje_Gmail_Confirmar.Visible = true;
                    validar_inicio = false;
                }
                if (txtContrasena.Text == "")
                {
                    lblMensaje_Contrasena_.Visible = true;
                    validar_inicio = false;
                }
                if (txtConfirmar_Contrasena.Text == "")
                {
                    lblMensaje_Contrasena_Confirmar.Visible = true;
                    validar_inicio = false;
                }

                if (validar_inicio == true)
                {
                    Usuario usuarioParaRegistrar = new Usuario(txtUsuario.Text, txtContrasena.Text, txtGmail.Text, Enums.RolUsuario.Usuario, Enums.EstadoUsuario.Activo);
                    UsuarioController control = new UsuarioController();

                    if (control.RegistrarUsuario(usuarioParaRegistrar))
                    {
                        MessageBox.Show("¡Usuario registrado con éxito en la base de datos!", "GeoIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuenta: " + ex.Message);
            }
        }

        private void lblIniciar_Sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
