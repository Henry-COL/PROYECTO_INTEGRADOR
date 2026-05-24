using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Models;

namespace GeoIntegral.Controller
{
    public class ClienteController
    {
        private string rutaClientes = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Clientes.csv"));
        public bool RegistrarCliente(Cliente nuevoCliente)
        {
            try
            {
                string linea = $"{nuevoCliente.Identificacion};{nuevoCliente.Nombre};{nuevoCliente.Telefono};{nuevoCliente.Correo}{Environment.NewLine}";
                File.AppendAllText(rutaClientes, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
                return false;
            }
        }

        public bool ClienteExiste(long identificacion)
        {
            if (!File.Exists(rutaClientes))
            {
                return false;
            }

            var lineas = File.ReadAllLines(rutaClientes).Skip(1);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(';');
                if (datos[0] == identificacion.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
