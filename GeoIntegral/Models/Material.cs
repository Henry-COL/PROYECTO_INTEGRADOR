namespace GeoIntegral.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double CostoUnidad { get; set; }

        public Material(int id, string nombre, double costoUnidad)
        {
            Id = id;
            Nombre = nombre;
            CostoUnidad = costoUnidad;
        }
    }
}