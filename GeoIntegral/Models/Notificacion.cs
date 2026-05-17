using GeoIntegral.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GeoIntegral.Models
{
    public class Notificacion
    {
        private static long _ultimoId = 0;
        public long IdNotificacion { get; set; } = 1;
        public string NombreUsuario { get; set; }
        public string Mensaje { get; set; } = "Olvido de contrseña";
        public string Fecha { get; set; } = DateTime.Today.ToString("dd/MM/yyyy");
        public EstadoNotificacion Estado { get; set; } = EstadoNotificacion.Pendiente;

        public Notificacion(long idNotificacion, string nombreusuario, string mensaje, string fecha, EstadoNotificacion estado)
        {
            _ultimoId++;
            this.IdNotificacion = _ultimoId;
            this.NombreUsuario = nombreusuario;
            this.Mensaje = mensaje;
            this.Fecha = fecha;
            this.Estado = estado;
        }
    }
}
