using GeoIntegral.Enums;
using System;
using System.IO;
using System.Windows.Forms;

namespace GeoIntegral.Controller
{
    public class NotificacionController
    {
        private string rutaNotificaciones = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Notificaciones.csv"));

        public bool RegistrarNotificacion(string idNotificacion, string idUsuario, string mensaje, string fecha, EstadoNotificacion leida)
        {
            try
            {
                string linea = $"{idNotificacion};{idUsuario};{mensaje};{fecha};{leida}{Environment.NewLine}";
                File.AppendAllText(rutaNotificaciones, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
                return false;
            }
        }
    }
}
