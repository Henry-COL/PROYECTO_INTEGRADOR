using GeoIntegral.Models;
using GeoIntegral.Repositorys;
using System.Collections.Generic;

namespace GeoIntegral.Controller
{
    public class CotizacionController
    {
        private CotizacionRepository repo = new CotizacionRepository();

        public bool GenerarCotizacion(long idCliente, int idTerreno, string material, double volumen, double costoUnidad)
        {
            double costoTotal = volumen * costoUnidad;
            string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");
            Cotizacion cotizacion = new Cotizacion(repo.GenerarNuevoId(),idCliente,idTerreno, material, costoTotal, fecha, "Pendiente");
            return repo.Guardar(cotizacion);
        }

        public List<Cotizacion> ObtenerTodas()
        {
            return repo.ObtenerTodas();
        }

        public Cotizacion ObtenerPorId(int id)
        {
            return repo.ObtenerPorId(id);
        }

        public bool CambiarEstado(int idCotizacion, string nuevoEstado)
        {
            return repo.CambiarEstado(idCotizacion, nuevoEstado);
        }
    }
}