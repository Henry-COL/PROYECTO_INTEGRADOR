using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using MathNet.Numerics.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Controller
{
    public class TerrenoController
    {
        private TerrenoRepository repo = new TerrenoRepository();
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
                var terreno = new Terreno(repo.GenerarNuevoId(), nombreProyecto);
                terreno.FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");
                terreno.Volumen = CalcularVolumen();
                terreno.Observaciones = observaciones;
                terreno.Puntos = new List<PuntoTerreno>(puntos);

                return repo.Guardar(terreno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar terreno: " + ex.Message);
                return false;
            }
        }

        public List<Terreno> ObtenerTodosLosTerrenos()
        {
            return repo.ObtenerTodos();
        }

        public Terreno ObtenerTerrenoPorId(int id)
        {
            return repo.ObtenerPorId(id);
        }

        public List<PuntoTerreno> ObtenerCoordenadas(int idTerreno)
        {
            return repo.ObtenerCoordenadas(idTerreno);
        }
    }
}