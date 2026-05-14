using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Recuperar_Screen : Form
    {
        public Recuperar_Screen()
        {
            InitializeComponent();
        }


        private void btnCerrar_App_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNotificar_Admin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si no ha podido recuperar su contraseña, puede enviar una notificación al administrador para solicitar ayuda.Presione Aceptar para notificar al administrador o Cancelar para intentar de nuevo.", "Recuperar Contraseña", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
