using GeoIntegral.Models;
using MathNet.Numerics.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Controller
{
    public class TerrenoController
    {
        private string rutaTerrenos = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Terrenos.csv"));
        private string rutaCoordenadas = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Coordenadas_Terreno.csv"));

        private List<PuntoTerreno> puntos = new List<PuntoTerreno>();

        public void AgregarPunto(double x, double y, double z)
        {
            puntos.Add(new PuntoTerreno(x, y, z));
        }

        public void LimpiarPuntos()
        {
            puntos.Clear();
        }

        public List<PuntoTerreno> ObtenerPuntos()
        {
            return puntos;
        }

        public double CalcularArea()
        {
            int n = puntos.Count;
            if (n < 3) return 0;

            double area = 0;
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += puntos[i].X * puntos[j].Y;
                area -= puntos[j].X * puntos[i].Y;
            }
            return Math.Abs(area) / 2.0;
        }

        public double CalcularVolumen()
        {
            if (puntos.Count < 3) return 0;

            double xMin = puntos.Min(p => p.X);
            double xMax = puntos.Max(p => p.X);
            double yMin = puntos.Min(p => p.Y);
            double yMax = puntos.Max(p => p.Y);

            double volumen = GaussLegendreRule.Integrate(
                x => GaussLegendreRule.Integrate(
                    y => ObtenerZ(x, y),
                    yMin, yMax, 64),
                xMin, xMax, 64);

            return Math.Abs(volumen);
        }

        private double ObtenerZ(double x, double y)
        {
            double sumaPesos = 0;
            double sumaZPeso = 0;

            foreach (var p in puntos)
            {
                double distancia = Math.Sqrt(
                    Math.Pow(x - p.X, 2) +
                    Math.Pow(y - p.Y, 2));

                if (distancia < 1e-10) return p.Z;

                double peso = 1.0 / (distancia * distancia);
                sumaPesos += peso;
                sumaZPeso += peso * p.Z;
            }
            return sumaZPeso / sumaPesos;
        }

        public bool GuardarTerreno(string nombreProyecto, string observaciones)
        {
            try
            {
                int id = GenerarNuevoId();
                double area = CalcularArea();
                double volumen = CalcularVolumen();
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");

                // Guardar terreno
                string lineaTerreno = $"{id};{fecha};{nombreProyecto};{volumen};{observaciones}{Environment.NewLine}";
                File.AppendAllText(rutaTerrenos, lineaTerreno);

                // Guardar coordenadas
                foreach (var p in puntos)
                {
                    string lineaCoordenada = $"{id};{p.X};{p.Y};{p.Z}{Environment.NewLine}";
                    File.AppendAllText(rutaCoordenadas, lineaCoordenada);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar terreno: " + ex.Message);
                return false;
            }
        }

        private int GenerarNuevoId()
        {
            if (!File.Exists(rutaTerrenos)) return 1;
            var lineas = File.ReadAllLines(rutaTerrenos).Skip(1)
                .Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
            if (lineas.Count == 0) return 1;
            return lineas.Select(l => int.Parse(l.Split(';')[0])).Max() + 1;
        }

        public List<Terreno> ObtenerTodosLosTerrenos()
        {
            var lista = new List<Terreno>();
            if (!File.Exists(rutaTerrenos)) return lista;

            var lineas = File.ReadAllLines(rutaTerrenos).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] datos = linea.Split(';');
                var terreno = new Terreno(int.Parse(datos[0]), datos[2]);
                terreno.Volumen = double.Parse(datos[3]);
                lista.Add(terreno);
            }
            return lista;
        }
    }
}