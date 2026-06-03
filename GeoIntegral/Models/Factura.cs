namespace GeoIntegral.Models
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public int IdCotizacion { get; set; }
        public long IdentificacionCliente { get; set; }
        public string FechaEmision { get; set; }
        public string Estado { get; set; }

        public Factura(int numeroFactura, int idCotizacion, long identificacionCliente,
            string fechaEmision, string estado)
        {
            NumeroFactura = numeroFactura;
            IdCotizacion = idCotizacion;
            IdentificacionCliente = identificacionCliente;
            FechaEmision = fechaEmision;
            Estado = estado;
        }
    }
}