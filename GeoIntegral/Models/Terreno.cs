using System.Collections.Generic;

namespace GeoIntegral.Models
{
    public class Terreno
    {
        public int Id { get; set; }
        public string FechaRegistro { get; set; }
        public string NombreProyecto { get; set; }
        public double Volumen { get; set; }
        public string Observaciones { get; set; }
        public List<PuntoTerreno> Puntos { get; set; }

        public Terreno(int id, string nombreProyecto)
        {
            Id = id;
            NombreProyecto = nombreProyecto;
            Puntos = new List<PuntoTerreno>();
        }
    }
}