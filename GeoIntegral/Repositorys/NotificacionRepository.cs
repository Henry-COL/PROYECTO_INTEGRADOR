using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Enums;
using GeoIntegral.Models;

namespace GeoIntegral.Repositorys
{
    public class NotificacionRepository
    {
        private string rutaNotificaciones = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Notificaciones.csv"));

        public bool Agregar(Notificacion notificacion)
        {
            string linea = $"{notificacion.IdNotificacion};{notificacion.NombreUsuario};" +
                           $"{notificacion.Mensaje};{notificacion.Fecha};{notificacion.Estado}{Environment.NewLine}";
            File.AppendAllText(rutaNotificaciones, linea);
            return true;
        }

        public List<string[]> ObtenerLineas()
        {
            if (!File.Exists(rutaNotificaciones))
            {
                return new List<string[]>();
            }
                

            return File.ReadAllLines(rutaNotificaciones)
                       .Skip(1)
                       .Where(l => !string.IsNullOrWhiteSpace(l))
                       .Select(l => l.Split(';'))
                       .ToList();
        }

        public bool ActualizarCampo(long idNotificacion, int indiceCampo, string nuevoValor)
        {
            if (!File.Exists(rutaNotificaciones))
            {
                return false;
            }
                

            var lineas = File.ReadAllLines(rutaNotificaciones);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                } 

                string[] datos = lineas[i].Split(';');

                if (long.TryParse(datos[0], out long id) && id == idNotificacion)
                {
                    datos[indiceCampo] = nuevoValor;
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(rutaNotificaciones, lineas);
            return true;
        }

        public long ObtenerProximoId()
        {
            if (!File.Exists(rutaNotificaciones))
            {
                return 1;
            }
                

            var lineas = File.ReadAllLines(rutaNotificaciones);
            long maxId = 0;

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }
                    
                string[] datos = lineas[i].Split(';');

                if (long.TryParse(datos[0], out long id) && id > maxId)
                {
                    maxId = id;
                }
                    
            }

            return maxId + 1;
        }
    }
}