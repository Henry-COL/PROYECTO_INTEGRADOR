using GeoIntegral.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoIntegral.DataBase;

namespace GeoIntegral
{
    internal class Main_Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            // Use GDI text rendering to avoid System.Drawing.TextRenderingHint errors in some custom controls (Guna2)
            Application.SetCompatibleTextRenderingDefault(true);

            ArchivosCSV archivos = new ArchivosCSV();
            archivos.CrearInfraestructura();

            Application.Run(new Login_Screen());
        }
    }
}