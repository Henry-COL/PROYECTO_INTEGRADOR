using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public class CotizacionRepository
    {
        private string rutaCotizaciones = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Cotizaciones.csv"));

        public bool Guardar(Cotizacion cotizacion)
        {
            try
            {
                string linea = $"{cotizacion.IdCotizacion};{cotizacion.IdentificacionCliente};{cotizacion.IdTerreno};{cotizacion.Material};{cotizacion.CostoTotal};{cotizacion.Fecha};{cotizacion.Estado}{Environment.NewLine}";
                File.AppendAllText(rutaCotizaciones, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cotización: " + ex.Message);
                return false;
            }
        }

        public List<Cotizacion> ObtenerTodas()
        {
            var lista = new List<Cotizacion>();
            if (!File.Exists(rutaCotizaciones)) return lista;

            var lineas = File.ReadAllLines(rutaCotizaciones).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                lista.Add(new Cotizacion(
                    int.Parse(d[0]),
                    long.Parse(d[1]),
                    int.Parse(d[2]),
                    d[3],
                    double.Parse(d[4]),
                    d[5],
                    d[6].Trim()
                ));
            }
            return lista;
        }

        public int GenerarNuevoId()
        {
            var lista = ObtenerTodas();
            if (lista.Count == 0) return 1;
            return lista.Max(c => c.IdCotizacion) + 1;
        }

        public Cotizacion ObtenerPorId(int id)
        {
            return ObtenerTodas().FirstOrDefault(c => c.IdCotizacion == id);
        }
    }
}