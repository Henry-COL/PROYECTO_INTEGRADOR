using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public class FacturaRepository
    {
        private string rutaFacturas;

        public FacturaRepository()
        {
            rutaFacturas = ResolveRuta("Facturas.csv");
        }

        private string ResolveRuta(string archivo)
        {
            try
            {
                var candidate1 = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", archivo));
                var candidate2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", archivo));

                if (File.Exists(candidate1)) return candidate1;
                if (File.Exists(candidate2)) return candidate2;

                return candidate1;
            }
            catch
            {
                return Path.Combine("DataBase", archivo);
            }
        }

        private void AsegurarArchivo()
        {
            var dir = Path.GetDirectoryName(rutaFacturas);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            if (!File.Exists(rutaFacturas))
                File.WriteAllText(rutaFacturas, $"NumeroFactura;IdCotizacion;IdentificacionCliente;FechaEmision;Estado{Environment.NewLine}");
        }

        public bool Guardar(Factura factura)
        {
            try
            {
                AsegurarArchivo();
                string linea = $"{factura.NumeroFactura};{factura.IdCotizacion};{factura.IdentificacionCliente};{factura.FechaEmision};{factura.Estado}{Environment.NewLine}";
                File.AppendAllText(rutaFacturas, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar factura: " + ex.Message);
                return false;
            }
        }

        public List<Factura> ObtenerTodas()
        {
            var lista = new List<Factura>();
            if (!File.Exists(rutaFacturas)) return lista;

            foreach (var linea in File.ReadAllLines(rutaFacturas).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                if (d.Length < 5) continue;

                lista.Add(new Factura(
                    int.Parse(d[0]),
                    int.Parse(d[1]),
                    long.Parse(d[2]),
                    d[3],
                    d[4]
                ));
            }
            return lista;
        }

        public Factura ObtenerPorNumero(int numeroFactura)
        {
            return ObtenerTodas().FirstOrDefault(f => f.NumeroFactura == numeroFactura);
        }

        public int GenerarNuevoNumero()
        {
            var lista = ObtenerTodas();
            if (lista.Count == 0) return 1;
            return lista.Max(f => f.NumeroFactura) + 1;
        }

        public bool CambiarEstado(int numeroFactura, string nuevoEstado)
        {
            try
            {
                AsegurarArchivo();
                var lineas = File.ReadAllLines(rutaFacturas).ToList();

                for (int i = 1; i < lineas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                    string[] d = lineas[i].Split(';');
                    if (d.Length < 5) continue;

                    if (int.Parse(d[0]) == numeroFactura)
                    {
                        d[4] = nuevoEstado;
                        lineas[i] = string.Join(";", d);
                        break;
                    }
                }

                File.WriteAllLines(rutaFacturas, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int numeroFactura)
        {
            try
            {
                AsegurarArchivo();
                var lineas = File.ReadAllLines(rutaFacturas).ToList();
                lineas.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l)) return false;
                    string[] d = l.Split(';');
                    return d.Length >= 1 && d[0] == numeroFactura.ToString();
                });

                File.WriteAllLines(rutaFacturas, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar factura: " + ex.Message);
                return false;
            }
        }
    }
}