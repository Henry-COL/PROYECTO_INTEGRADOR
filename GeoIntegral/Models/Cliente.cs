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
        public string Nombre_Cliente { get; set; }
        public string NumeroTelefono { get; set; }
        public string Gmail_Cliente { get; set; }

        public Cliente(long identificacion, string nombreCliente, string numeroTelefono, string gmailCliente)
        {
            this.Identificacion = identificacion;
            this.Nombre_Cliente = nombreCliente;
            this.NumeroTelefono = numeroTelefono;
            this.Gmail_Cliente = gmailCliente;
        }

    }
}
