using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using System.Collections.Generic;

namespace GeoIntegral.Controller
{
    public class FacturaController
    {
        private readonly FacturaRepository facturaRepository = new FacturaRepository();

        public List<Factura> ObtenerTodas()
        {
            return facturaRepository.ObtenerTodas();
        }

        public Factura ObtenerPorNumero(int numeroFactura)
        {
            return facturaRepository.ObtenerPorNumero(numeroFactura);
        }

        public bool GenerarFactura(int idCotizacion, long identificacionCliente)
        {
            int nuevoNumero = facturaRepository.GenerarNuevoNumero();

            var factura = new Factura(
                nuevoNumero,
                idCotizacion,
                identificacionCliente,
                System.DateTime.Now.ToString("yyyy-MM-dd"),
                "Activa"
            );

            return facturaRepository.Guardar(factura);
        }

        public bool CambiarEstado(int numeroFactura, string nuevoEstado)
        {
            return facturaRepository.CambiarEstado(numeroFactura, nuevoEstado);
        }

        public bool Eliminar(int numeroFactura)
        {
            return facturaRepository.Eliminar(numeroFactura);
        }
    }
}