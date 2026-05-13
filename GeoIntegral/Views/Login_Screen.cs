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

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if(usuario == "" || contraseña == "")
            {
                MessageBox.Show("El usuario y contraseña no son válidos.");

            } else if(usuario == "admin" || contraseña == "1234")
            {
                
            }
        }
    }
}
