using GeoIntegral.Enums;
using System;

namespace GeoIntegral.Models
{
    public class Notificacion
    {
        public long IdNotificacion { get; set; } = 1;
        public string NombreUsuario { get; set; }
        public string Mensaje { get; set; } = "Olvido de contraseña";
        public string Fecha { get; set; } = DateTime.Today.ToString("dd/MM/yyyy");
        public EstadoNotificacion Estado { get; set; } = EstadoNotificacion.Pendiente;

        public Notificacion(long idNotificacion, string nombreUsuario, string mensaje, string fecha, EstadoNotificacion estado)
        {
            this.IdNotificacion = idNotificacion;
            this.NombreUsuario = nombreUsuario;
            this.Mensaje = mensaje;
            this.Fecha = fecha;
            this.Estado = estado;
        }
    }
}