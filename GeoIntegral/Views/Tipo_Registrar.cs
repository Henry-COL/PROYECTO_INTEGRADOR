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
    public partial class Tipo_Registrar : Form
    {
        public Tipo_Registrar()
        {
            InitializeComponent();
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCuentaPersonal_Click(object sender, EventArgs e)
        {
            this.Close();
            var Registrar_Personal = new Registrar_Screen();
            Registrar_Personal.Show();
        }
    }
}
