using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeoIntegral.Controller
{
    public class TerrenoController
    {
        private TerrenoRepository repo = new TerrenoRepository();
        private List<PuntoTerreno> puntos = new List<PuntoTerreno>();

        public void AgregarPunto(double x, double y, double z) => puntos.Add(new PuntoTerreno(x, y, z));
        public void LimpiarPuntos() => puntos.Clear();
        public List<PuntoTerreno> ObtenerPuntos() => puntos;

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

            int n = 50; // Densidad para cálculo matemático preciso
            double dx = (xMax - xMin) / n;
            double dy = (yMax - yMin) / n;
            double volumen = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = xMin + (i + 0.5) * dx;
                    double y = yMin + (j + 0.5) * dy;
                    double z = ObtenerZ(x, y);
                    volumen += z * dx * dy;
                }
            }
            return Math.Abs(volumen);
        }

        private double ObtenerZ(double x, double y)
        {
            double sumaPesos = 0;
            double sumaZPeso = 0;

            foreach (var p in puntos)
            {
                double distancia = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));
                if (distancia < 1e-10) return p.Z;

                double peso = 1.0 / (distancia * distancia);
                sumaPesos += peso;
                sumaZPeso += peso * p.Z;
            }
            return sumaZPeso / sumaPesos;
        }

        public double ObtenerZPublico(double x, double y) => ObtenerZ(x, y);

        /// <summary>
        /// MUDANZA DE LA VISTA AL CONTROLADOR:
        /// Procesa y normaliza los datos geométricos para que la Vista (OpenGL) solo tenga que dibujarlos.
        /// </summary>
        public (List<(float x, float y, float z, float t)> Celdas, List<(float x, float y, float z)> PuntosGL) GenerarMallaRiemann(int resolucionMalla = 30)
        {
            var celdasCalculadas = new List<(float, float, float, float)>();
            var puntosNormalizados = new List<(float, float, float)>();

            if (puntos.Count == 0) return (celdasCalculadas, puntosNormalizados);

            // 1. Obtener extremos reales
            float xMin = (float)puntos.Min(p => p.X);
            float xMax = (float)puntos.Max(p => p.X);
            float yMin = (float)puntos.Min(p => p.Y);
            float yMax = (float)puntos.Max(p => p.Y);
            float zMin = (float)puntos.Min(p => p.Z);
            float zMax = (float)puntos.Max(p => p.Z);

            float rx = (xMax - xMin) == 0 ? 1f : (xMax - xMin);
            float ry = (yMax - yMin) == 0 ? 1f : (yMax - yMin);
            float rz = (zMax - zMin) == 0 ? 1f : (zMax - zMin);

            // 2. Normalizar puntos de control originales para OpenTK (-0.5 a 0.5)
            foreach (var p in puntos)
            {
                puntosNormalizados.Add((
                    ((float)p.X - xMin) / rx - 0.5f,
                    ((float)p.Y - yMin) / ry - 0.5f,
                    ((float)p.Z - zMin) / rz - 0.5f
                ));
            }

            // 3. Construir grilla de Quads de Riemann normalizados
            float dx = (xMax - xMin) / resolucionMalla;
            float dy = (yMax - yMin) / resolucionMalla;

            for (int i = 0; i < resolucionMalla; i++)
            {
                for (int j = 0; j < resolucionMalla; j++)
                {
                    float x0 = xMin + i * dx;
                    float y0 = yMin + j * dy;
                    float x1 = x0 + dx;
                    float y1 = y0 + dy;

                    float xc = (x0 + x1) / 2f;
                    float yc = (y0 + y1) / 2f;
                    float zc = (float)ObtenerZ(xc, yc);
                    float t = (rz == 0) ? 0.5f : (zc - zMin) / rz;

                    float nx0 = (x0 - xMin) / rx - 0.5f;
                    float nx1 = (x1 - xMin) / rx - 0.5f;
                    float ny0 = (y0 - yMin) / ry - 0.5f;
                    float ny1 = (y1 - yMin) / ry - 0.5f;
                    float nz = (zc - zMin) / rz - 0.5f;

                    // Formar el Quad (en sentido antihorario preferiblemente)
                    celdasCalculadas.Add((nx0, ny0, nz, t));
                    celdasCalculadas.Add((nx1, ny0, nz, t));
                    celdasCalculadas.Add((nx1, ny1, nz, t));
                    celdasCalculadas.Add((nx0, ny1, nz, t));
                }
            }

            return (celdasCalculadas, puntosNormalizados);
        }

        // Corrección arquitectónica: Eliminado el MessageBox de aquí. 
        // Si hay una excepción, se propaga y la Vista decide cómo mostrarla.
        public bool GuardarTerreno(string nombreProyecto, string observaciones)
        {
            var terreno = new Terreno(repo.GenerarNuevoId(), nombreProyecto)
            {
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd"),
                Volumen = CalcularVolumen(),
                Area = CalcularArea(),
                Observaciones = observaciones,
                Puntos = new List<PuntoTerreno>(puntos)
            };

            return repo.Guardar(terreno);
        }

        public List<Terreno> ObtenerTodosLosTerrenos() => repo.ObtenerTodos();
        public Terreno ObtenerTerrenoPorId(int id) => repo.ObtenerPorId(id);
        public List<PuntoTerreno> ObtenerCoordenadas(int idTerreno) => repo.ObtenerCoordenadas(idTerreno);
    }
}