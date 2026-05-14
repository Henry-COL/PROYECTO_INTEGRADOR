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
                    MessageBox.Show("Cuenta registrada exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuenta: " + ex.Message);
            }
        }
    }
}
