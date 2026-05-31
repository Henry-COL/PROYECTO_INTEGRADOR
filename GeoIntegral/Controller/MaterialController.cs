using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using System.Collections.Generic;

namespace GeoIntegral.Controller
{
    public class MaterialController
    {
        private MaterialRepository repo = new MaterialRepository();

        public bool RegistrarMaterial(Material material)
        {
            return repo.Agregar(material);
        }

        public List<Material> ObtenerTodosLosMateriales()
        {
            return repo.ObtenerTodos();
        }

        public int GenerarNuevoId()
        {
            return repo.GenerarNuevoId();
        }

        public bool EliminarMaterial(int id)
        {
            return repo.Eliminar(id);
        }

        public bool MaterialExiste(string nombre)
        {
            return repo.Existe(nombre);
        }
    }
}