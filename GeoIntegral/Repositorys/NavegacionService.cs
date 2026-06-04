using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public static class NavegacionService
    {
        private static Control botonActivo = null;

        public static void ActivarBoton(Control boton)
        {
            if (botonActivo != null)
                botonActivo.Enabled = true;

            botonActivo = boton;

            if (boton != null)
                boton.Enabled = false;
        }

        public static void LiberarBoton()
        {
            if (botonActivo != null)
                botonActivo.Enabled = true;

            botonActivo = null;
        }
    }
}