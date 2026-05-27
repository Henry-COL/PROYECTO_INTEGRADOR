namespace GeoIntegral.Models
{
    public class PuntoTerreno
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public PuntoTerreno(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}