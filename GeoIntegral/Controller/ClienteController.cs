using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using System.Collections.Generic;

namespace GeoIntegral.Controller
{
    public class ClienteController
    {
        private ClienteRepository repo = new ClienteRepository();

        public bool RegistrarCliente(Cliente nuevoCliente)
        {
            return repo.Agregar(nuevoCliente);
        }

        public bool ClienteExiste(long identificacion)
        {
            return repo.Existe(identificacion);
        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            return repo.ObtenerTodos();
        }

        public bool EliminarCliente(long identificacion)
        {
            return repo.Eliminar(identificacion);
        }
    }
}