using GeoIntegral.Enums;

namespace GeoIntegral.Models
{
    public class Usuario
    {
        public string Nombre_Usuario { get; set; }
        public string PasswordHash { get; set; }
        public string Gmail { get; set; }
        public RolUsuario Rol { get; set; }
        public EstadoUsuario Estado { get; set; } = EstadoUsuario.Activo;

        public Usuario(string nombreUsuario, string passwordHash, string gmail, RolUsuario rol, EstadoUsuario estado)
        {
            this.Nombre_Usuario = nombreUsuario;
            this.PasswordHash = passwordHash;
            this.Gmail = gmail;
            this.Rol = rol;
            this.Estado = estado;
        }
    }
}