using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Enums;
using GeoIntegral.Models;

namespace GeoIntegral.Controller
{
    public class NotificacionController
    {
        private string rutaNotificaciones = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Notificaciones.csv"));

        private long ObtenerProximoId()
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
        public bool RegistrarNotificacion(Notificacion notificacion)
        {
            try
            {
                notificacion.IdNotificacion = ObtenerProximoId(); // ── NUEVO
                string linea = $"{notificacion.IdNotificacion};{notificacion.NombreUsuario};{notificacion.Mensaje};{notificacion.Fecha};{notificacion.Estado}{Environment.NewLine}";
                File.AppendAllText(rutaNotificaciones, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
                return false;
            }
        }

        public List<Notificacion> ObtenerNotificaciones()
        {
            var lista = new List<Notificacion>();

            if (!File.Exists(rutaNotificaciones)) 
            {
                return lista;
            }
            
            var lineas = File.ReadAllLines(rutaNotificaciones);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                } 

                string[] datos = lineas[i].Split(';');

                EstadoNotificacion estado = (EstadoNotificacion)Enum.Parse(typeof(EstadoNotificacion), datos[4].Trim());

                lista.Add(new Notificacion(
                    long.Parse(datos[0]),
                    datos[1],
                    datos[2],
                    datos[3],
                    estado
                ));
            }
            return lista;
        }

        public bool MarcarComoLeida(string idNotificacion)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaNotificaciones);

                for (int i = 1; i < lineas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        continue;
                    }

                    string[] datos = lineas[i].Split(';');

                    if (datos[0] == idNotificacion)
                    {
                        datos[4] = EstadoNotificacion.Leida.ToString();
                        lineas[i] = string.Join(";", datos);
                        break;
                    }
                }

                File.WriteAllLines(rutaNotificaciones, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar notificación: " + ex.Message);
                return false;
            }
        }

        public bool TieneNotificacionPendiente(string nombreUsuario)
        {
            if (!File.Exists(rutaNotificaciones))
            {
                return false;
            }

            var lineas = File.ReadAllLines(rutaNotificaciones).Skip(1);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(';');

                if (datos[1] == nombreUsuario && datos[4].Trim() == EstadoNotificacion.Pendiente.ToString()) 
                {
                    return true;
                }
                    
            }
            return false;
        }

        public bool MarcarNotificacionPorUsuario(string nombreUsuario)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaNotificaciones);
                for (int i = 1; i < lineas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        continue;
                    }

                    string[] datos = lineas[i].Split(';');

                    if (datos[1] == nombreUsuario && datos[4].Trim() == EstadoNotificacion.Pendiente.ToString())
                    {
                        datos[4] = EstadoNotificacion.Leida.ToString();
                        lineas[i] = string.Join(";", datos);
                    }
                }

                File.WriteAllLines(rutaNotificaciones, lineas);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar notificación: " + ex.Message);
                return false;
            }
        }
    }
}