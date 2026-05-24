using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GeoIntegral.Models
{
    public class Cliente
    {
        public long Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente(long identificacion, string nombreCliente, string numeroTelefono, string correoCliente)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombreCliente;
            this.Telefono = numeroTelefono;
            this.Correo = correoCliente;
        }

    }
}