using System;
using System.Collections.Generic;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using GeoIntegral.Repositorys;

namespace GeoIntegral.Controller
{
    public class NotificacionController
    {
        private readonly NotificacionRepository repo = new NotificacionRepository();

        public bool RegistrarNotificacion(Notificacion notificacion)
        {
            try
            {
                notificacion.IdNotificacion = repo.ObtenerProximoId();
                return repo.Agregar(notificacion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la notificación en la base de datos: " + ex.Message);
            }
        }

        public List<Notificacion> ObtenerNotificaciones()
        {
            var lista = new List<Notificacion>();

            foreach (var datos in repo.ObtenerLineas())
            {
                EstadoNotificacion estado = (EstadoNotificacion)Enum.Parse(typeof(EstadoNotificacion), datos[4].Trim());

                lista.Add(new Notificacion(
                    long.Parse(datos[0].Trim()),
                    datos[1].Trim(),
                    datos[2].Trim(),
                    datos[3].Trim(),
                    estado
                ));
            }

            return lista;
        }

        public bool MarcarComoLeida(string idNotificacion)
        {
            try
            {
                if (long.TryParse(idNotificacion, out long id))
                    return repo.ActualizarCampo(id, 4, EstadoNotificacion.Leida.ToString());

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado de la notificación: " + ex.Message);
            }
        }

        public bool TieneNotificacionPendiente(string nombreUsuario)
        {
            foreach (var datos in repo.ObtenerLineas())
            {
                if (datos[1].Trim() == nombreUsuario.Trim() && datos[4].Trim() == EstadoNotificacion.Pendiente.ToString())
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
                foreach (var datos in repo.ObtenerLineas())
                {
                    if (datos[1].Trim() == nombreUsuario.Trim() && datos[4].Trim() == EstadoNotificacion.Pendiente.ToString())
                    {
                        long id = long.Parse(datos[0].Trim());
                        repo.ActualizarCampo(id, 4, EstadoNotificacion.Leida.ToString());
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar las notificaciones del usuario: " + ex.Message);
            }
        }
    }
}