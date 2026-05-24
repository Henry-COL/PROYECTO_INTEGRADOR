using GeoIntegral.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace GeoIntegral.Controller
{
    public class ClienteController
    {
        private string rutaClientes = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Clientes.csv"));
        public bool RegistrarCliente(Cliente nuevoCliente)
        {
            try
            {
                string linea = $"{nuevoCliente.Identificacion};{nuevoCliente.Nombre_Cliente};{nuevoCliente.NumeroTelefono};{nuevoCliente.Gmail_Cliente}{Environment.NewLine}";
                File.AppendAllText(rutaClientes, linea);
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
