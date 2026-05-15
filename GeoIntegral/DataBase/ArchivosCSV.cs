using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral.DataBase
{
    internal class ArchivosCSV
    {
        private string rutaBase = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase"));

        public void CrearInfraestructura()
        {
            if (!Directory.Exists(rutaBase))
            {
                Directory.CreateDirectory(rutaBase);
            }
            string[] archivos = { "Usuarios.csv", "Clientes.csv", "Materiales.csv", "Terrenos.csv", "Cotizaciones.csv", "Facturas.csv", "Coordenadas_terreno.csv" };

            foreach (string nombre in archivos)
            {
                string path = Path.Combine(rutaBase, nombre);

                if (!File.Exists(path))
                {
                    if (nombre == "Usuarios.csv")
                    {
                        File.WriteAllText(path, "Usuario;PasswordHash;Gmail;Rol;Estado\n");
                    }
                    else if (nombre == "Clientes.csv")
                    {
                        File.WriteAllText(path, "Identificacion;Nombre;Telefono;Correo\n");
                    }
                    else if (nombre == "Materiales.csv")
                    {
                        File.WriteAllText(path, "NombreMaterial;CostoUnidad\n");
                    }
                    else if (nombre == "Terrenos.csv")
                    {
                        File.WriteAllText(path, "IdTerreno;FechaRegistro;NombreProyecto;VolumenCalculado;Observaciones\n");
                    }
                    else if (nombre == "Coordenadas_terreno.csv")
                    {
                        File.WriteAllText(path, "IdTerreno;EjeX;EjeY;EjeZ\n");
                    }
                    else if (nombre == "Cotizaciones.csv")
                    {
                        File.WriteAllText(path, "IdCotizacion;IdentificacionCliente;IdTerreno;Material;CostoTotal;Fecha;Estado\n");
                    }
                    else if (nombre == "Facturas.csv")
                    {
                        File.WriteAllText(path, "NumeroFactura;IdCotizacion;IdentificacionCliente;FechaEmision;Estado\n");
                    }
                }
            }
        }
    }
}
