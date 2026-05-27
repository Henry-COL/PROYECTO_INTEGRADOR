using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeoIntegral.Controller
{
    public class MaterialController
    {
        private string rutaMateriales = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Materiales.csv"));

        public bool RegistrarMaterial(Material material)
        {
            try
            {
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

        public List<Material> ObtenerTodosLosMateriales()
        {
            var lista = new List<Material>();
            if (!File.Exists(rutaMateriales))
            {
                return lista;
            }

            var lineas = File.ReadAllLines(rutaMateriales).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }
                string[] datos = linea.Split(';');
                lista.Add(new Material(int.Parse(datos[0]), datos[1], double.Parse(datos[2])));
            }
            return lista;
        }

        public int GenerarNuevoId()
        {
            var materiales = ObtenerTodosLosMateriales();
            if (materiales.Count == 0)
            {
                return 1;
            }
            return materiales.Max(m => m.Id) + 1;
        }

        public bool EliminarMaterial(int id)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaMateriales).ToList();
                lineas.RemoveAll(l =>
                {
                    if (string.IsNullOrWhiteSpace(l))
                    {
                        return false;
                    }
                    string[] datos = l.Split(';');
                    return datos[0] == id.ToString();
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

        public bool MaterialExiste(string nombre)
        {
            var materiales = ObtenerTodosLosMateriales();
            return materiales.Exists(m => m.Nombre.ToLower() == nombre.ToLower());
        }
    }
}