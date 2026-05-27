using System;
using System.Collections.Generic;
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

        public List<Cliente> ObtenerTodosLosClientes()
        {
            var lista = new List<Cliente>();
            if (!File.Exists(rutaClientes)) return lista;

            var lineas = File.ReadAllLines(rutaClientes).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] datos = linea.Split(';');
                lista.Add(new Cliente(long.Parse(datos[0]), datos[1], datos[2], datos[3]));
            }
            return lista;
        }

        public bool EliminarCliente(long identificacion)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaClientes).ToList();
                lineas.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l)) return false;
                    string[] datos = l.Split(';');
                    return datos[0] == identificacion.ToString();
                });
                File.WriteAllLines(rutaClientes, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                return false;
            }
        }
    }
}
