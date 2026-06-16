namespace GeoIntegral.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public long IdentificacionCliente { get; set; }
        public int IdTerreno { get; set; }
        // Nombre del proyecto asociado al terreno/cotización
        public string NombreProyecto { get; set; }
        public string Material { get; set; }
        public double CostoTotal { get; set; }
        // Volumen calculado del terreno (en m³). Se puede asignar desde el controlador/repository.
        public double VolumenCalculado { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }

        public Cotizacion(int idCotizacion, long identificacionCliente, int idTerreno,
            string material, double costoTotal, string fecha, string estado, double volumenCalculado = 0.0, string nombreProyecto = "--")
        {
            IdCotizacion = idCotizacion;
            IdentificacionCliente = identificacionCliente;
            IdTerreno = idTerreno;
            NombreProyecto = nombreProyecto;
            Material = material;
            CostoTotal = costoTotal;
            Fecha = fecha;
            Estado = estado;
            VolumenCalculado = volumenCalculado;
        }
    }
}