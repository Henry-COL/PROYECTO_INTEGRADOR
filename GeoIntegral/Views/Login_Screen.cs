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
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRecuperar_Contrasena_Click(object sender, EventArgs e)
        {
            Recuperar_Screen Ventana_recuperar = new Recuperar_Screen();
            Ventana_recuperar.Show();
        }

        private void lblCrear_Cuenta_Click(object sender, EventArgs e)
        {
            Registrar_Screen Crear_cuenta = new Registrar_Screen();
            Crear_cuenta.Show();
        }

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje_Usuario.Visible = false;
                lblMensaje_Contrasena.Visible = false;
                bool validar_inicio = true;

                if (txtUsuario.Text == "")
                {
                    lblMensaje_Usuario.Visible = true;
                    validar_inicio = false;
                }
                if (txtContrasena.Text == "")
                {
                    lblMensaje_Contrasena.Visible = true;
                    validar_inicio = false;
                }
                if (validar_inicio == true)
                {
                   MessageBox.Show("Inicio de sesión exitoso");
                    var ventana_principal = new Principal_Screen();
                    ventana_principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
}
