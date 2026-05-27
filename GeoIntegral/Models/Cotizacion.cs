namespace GeoIntegral.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public long IdentificacionCliente { get; set; }
        public int IdTerreno { get; set; }
        public string Material { get; set; }
        public double CostoTotal { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }

        public Cotizacion(int idCotizacion, long identificacionCliente, int idTerreno,
            string material, double costoTotal, string fecha, string estado)
        {
            IdCotizacion = idCotizacion;
            IdentificacionCliente = identificacionCliente;
            IdTerreno = idTerreno;
            Material = material;
            CostoTotal = costoTotal;
            Fecha = fecha;
            Estado = estado;
        }
    }
}