using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Repositorys
{
    public class MaterialRepository
    {
        private string rutaMateriales;

        public MaterialRepository()
        {
            rutaMateriales = ResolveRuta();
        }

        private string ResolveRuta()
        {
            try
            {
                var candidate1 = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "Materiales.csv"));
                var candidate2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Materiales.csv"));

                if (File.Exists(candidate1)) return candidate1;
                if (File.Exists(candidate2)) return candidate2;

                return candidate1;
            }
            catch
            {
                return Path.Combine("DataBase", "Materiales.csv");
            }
        }

        public bool Agregar(Material material)
        {
            try
            {
                var dir = Path.GetDirectoryName(rutaMateriales);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                if (!File.Exists(rutaMateriales))
                    File.WriteAllText(rutaMateriales, $"Id;NombreMaterial;CostoUnidad{Environment.NewLine}");

                string linea = $"{material.Id};{material.Nombre};{material.CostoUnidad}{Environment.NewLine}";
                File.AppendAllText(rutaMateriales, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar material: " + ex.Message);
                return false;
            }
        }

        public List<Material> ObtenerTodos()
        {
            var lista = new List<Material>();
            if (!File.Exists(rutaMateriales)) return lista;

            foreach (var linea in File.ReadAllLines(rutaMateriales).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(';');
                lista.Add(new Material(int.Parse(d[0]), d[1], double.Parse(d[2])));
            }
            return lista;
        }

        public int GenerarNuevoId()
        {
            var lista = ObtenerTodos();
            if (lista.Count == 0) return 1;
            return lista.Max(m => m.Id) + 1;
        }

        public bool Existe(string nombre)
        {
            return ObtenerTodos().Any(m => m.Nombre.ToLower() == nombre.ToLower());
        }

        public bool Eliminar(int id)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaMateriales).ToList();
                lineas.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l)) return false;
                    string[] d = l.Split(';');
                    return d[0] == id.ToString();
                });
                File.WriteAllLines(rutaMateriales, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar material: " + ex.Message);
                return false;
            }
        }
    }
}