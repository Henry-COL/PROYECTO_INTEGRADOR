using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public class ClienteRepository
    {
        private string rutaClientes;

        public ClienteRepository()
        {
            rutaClientes = ResolveRuta();
        }

        private string ResolveRuta()
        {
            try
            {
                var candidate1 = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "Clientes.csv"));
                var candidate2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Clientes.csv"));

                if (File.Exists(candidate1)) return candidate1;
                if (File.Exists(candidate2)) return candidate2;

                return candidate1;
            }
            catch
            {
                return Path.Combine("DataBase", "Clientes.csv");
            }
        }

        public bool Agregar(Cliente cliente)
        {
            try
            {
                var dir = Path.GetDirectoryName(rutaClientes);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                if (!File.Exists(rutaClientes))
                    File.WriteAllText(rutaClientes, $"Identificacion;Nombre;Telefono;Correo{Environment.NewLine}");

                string linea = $"{cliente.Identificacion};{cliente.Nombre};{cliente.Telefono};{cliente.Correo}{Environment.NewLine}";
                File.AppendAllText(rutaClientes, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
                return false;
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            var lista = new List<Cliente>();
            if (!File.Exists(rutaClientes)) return lista;

            foreach (var linea in File.ReadAllLines(rutaClientes).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                lista.Add(new Cliente(long.Parse(d[0]), d[1], d[2], d[3]));
            }
            return lista;
        }

        public bool Existe(long identificacion)
        {
            return ObtenerTodos().Any(c => c.Identificacion == identificacion);
        }

        public bool Eliminar(long identificacion)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaClientes).ToList();
                lineas.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l)) return false;
                    string[] d = l.Split(';');
                    return d[0] == identificacion.ToString();
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