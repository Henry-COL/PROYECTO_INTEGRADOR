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
    public partial class Notificaciones_Panel : Form
    {
        public Notificaciones_Panel(Size tamano)
        {
            InitializeComponent();
            this.Size = tamano;
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}