using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public class TerrenoRepository
    {
        private string rutaTerrenos;
        private string rutaCoordenadas;

        public TerrenoRepository()
        {
            rutaTerrenos = ResolveRuta("Terrenos.csv");
            rutaCoordenadas = ResolveRuta("Coordenadas_Terreno.csv");
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

        public bool Guardar(Terreno terreno)
        {
            try
            {
                var dir = Path.GetDirectoryName(rutaTerrenos);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                if (!File.Exists(rutaTerrenos))
                    File.WriteAllText(rutaTerrenos, $"IdTerreno;FechaRegistro;NombreProyecto;VolumenCalculado;AreaCalculada;Observaciones{Environment.NewLine}");

                if (!File.Exists(rutaCoordenadas))
                    File.WriteAllText(rutaCoordenadas, $"IdTerreno;EjeX;EjeY;EjeZ{Environment.NewLine}");

                string lineaTerreno = $"{terreno.Id};{terreno.FechaRegistro};{terreno.NombreProyecto};{terreno.Volumen};{terreno.Area};{terreno.Observaciones}{Environment.NewLine}";
                File.AppendAllText(rutaTerrenos, lineaTerreno);

                foreach (var p in terreno.Puntos)
                {
                    string lineaCoordenada = $"{terreno.Id};{p.X};{p.Y};{p.Z}{Environment.NewLine}";
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

        public List<Terreno> ObtenerTodos()
        {
            var lista = new List<Terreno>();
            if (!File.Exists(rutaTerrenos)) return lista;

            foreach (var linea in File.ReadAllLines(rutaTerrenos).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                if (d.Length < 6) continue;

                var terreno = new Terreno(int.Parse(d[0]), d[2]);
                terreno.FechaRegistro = d[1];
                terreno.Volumen = double.Parse(d[3]);
                terreno.Area = double.Parse(d[4]);
                terreno.Observaciones = d[5];
                lista.Add(terreno);
            }
            return lista;
        }

        public Terreno ObtenerPorId(int id)
        {
            return ObtenerTodos().FirstOrDefault(t => t.Id == id);
        }

        public int GenerarNuevoId()
        {
            var lista = ObtenerTodos();
            if (lista.Count == 0) return 1;
            return lista.Max(t => t.Id) + 1;
        }

        public List<PuntoTerreno> ObtenerCoordenadas(int idTerreno)
        {
            var puntos = new List<PuntoTerreno>();
            if (!File.Exists(rutaCoordenadas)) return puntos;

            foreach (var linea in File.ReadAllLines(rutaCoordenadas).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                if (int.Parse(d[0]) == idTerreno)
                    puntos.Add(new PuntoTerreno(double.Parse(d[1]), double.Parse(d[2]), double.Parse(d[3])));
            }
            return puntos;
        }
    }
}