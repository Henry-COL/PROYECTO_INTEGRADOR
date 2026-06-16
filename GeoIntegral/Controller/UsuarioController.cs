using System;
using System.Collections.Generic;
using BCrypt.Net;
using GeoIntegral.Enums;
using GeoIntegral.Models;
using GeoIntegral.Repositorys;

namespace GeoIntegral.Controller
{
    public class UsuarioController
    {
        private readonly UsuarioRepository repo = new UsuarioRepository();

        // --- Metodo para registrar --- \\\

        public bool  RegistrarUsuario(Usuario nuevoUsuario, string gmailConfirmar, string passConfirmar)
        {
            if (!NombreEsValido(nuevoUsuario.Nombre_Usuario))
                throw new Exception("Usuario inválido: mínimo 4 caracteres, sin espacios ni símbolos no permitidos.");

            try
            {
                var correo = new System.Net.Mail.MailAddress(nuevoUsuario.Gmail);
            }
            catch
            {
                throw new Exception("Correo inválido.");
            }

            if (nuevoUsuario.Gmail != gmailConfirmar)
                throw new Exception("Los correos no coinciden.");

            if (GmailExiste(nuevoUsuario.Gmail))
                throw new Exception("Ese correo ya está registrado.");

            if (nuevoUsuario.PasswordHash != passConfirmar)
                throw new Exception("Las contraseñas no coinciden.");

            if (!ContrasenaEsValida(nuevoUsuario.PasswordHash))
                throw new Exception("La contraseña debe tener mínimo 8 caracteres, una mayúscula, un número y un carácter especial.");

            if (UsuarioExiste(nuevoUsuario.Nombre_Usuario))
                throw new Exception("Ese usuario ya existe.");

            try
            {
                nuevoUsuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(nuevoUsuario.PasswordHash);
                return repo.Agregar(nuevoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en base de datos: " + ex.Message);
            }
        }


        // --- Metodo para validar requisitos de contraseña --- \\\
        public bool ContrasenaEsValida(string contrasena)
        {
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 8)
                return false;

            bool tieneMayuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) tieneMayuscula = true;
                if (char.IsDigit(c)) tieneNumero = true;
                if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
            }
            return tieneMayuscula && tieneNumero && tieneEspecial;
        }

        // --- Metodo para validar requisitos de nombre de usuario --- \\\
        public bool NombreEsValido(string nombre)
        {
            if (string.IsNullOrEmpty(nombre) || nombre.Length <= 3) { return false; }
            foreach (char c in nombre)
            {
                if (!char.IsLetterOrDigit(c) && c != '_' && c != '-') { return false; }
            }
            return true;
        }

        // --- Metodo para autenticar --- \\\
        public Usuario Autenticar(string usuario, string password)
        {
            try
            {
                foreach (var datos in repo.ObtenerLineas())
                {
                    if (datos[0].Trim() == usuario.Trim())
                    {
                        bool passwordValido = BCrypt.Net.BCrypt.Verify(password, datos[1]);
                        if (!passwordValido)
                        {
                            break;
                        }
                        RolUsuario rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), datos[3].Trim());
                        EstadoUsuario estado = (EstadoUsuario)Enum.Parse(typeof(EstadoUsuario), datos[4].Trim());

                        if (estado == EstadoUsuario.Inactivo)
                        {
                            throw new Exception("INACTIVO");
                        }

                        return new Usuario(datos[0], datos[1], datos[2], rol, estado);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // --- Metodo para cambiar contraseña --- \\\
        public bool CambiarContrasena(string nombreUsuario, string nuevaContrasena)
        {
            try
            {
                string hashNueva = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);
                return repo.ActualizarCampo(nombreUsuario, 1, hashNueva);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar contraseña: " + ex.Message);
            }
        }

        // --- Metodo para verificar existencia de usuario --- \\\
        public bool UsuarioExiste(string nombreUsuario)
        {
            foreach (var datos in repo.ObtenerLineas())
            {
                // --- Validamos el dato con la nueva variable a comparar --- \\\
                if (datos[0].Trim() == nombreUsuario.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        // --- Metodo para verificar existencia de usuario y gmail --- \\\
        public bool VerificarUsuarioYGmail(string nombreUsuario, string gmail)
        {
            try
            {
                foreach (var datos in repo.ObtenerLineas())
                {
                    if (datos[0].Trim() == nombreUsuario.Trim() && datos[2].Trim() == gmail.Trim())
                    {
                        // --- Validamos contra el Enum o ignorando mayúsculas/minúsculas --- \\\
                        if (datos[4].Trim().Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        {
                            throw new Exception("INACTIVO");
                        }
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            var lista = new List<Usuario>();
            foreach (var datos in repo.ObtenerLineas())
            {
                RolUsuario rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), datos[3].Trim());
                EstadoUsuario estado = (EstadoUsuario)Enum.Parse(typeof(EstadoUsuario), datos[4].Trim());
                lista.Add(new Usuario(datos[0], datos[1], datos[2], rol, estado));
            }
            return lista;
        }

        // --- Metodo para cambiar estado de usuario --- \\\
        public bool CambiarEstadoUsuario(string nombreUsuario, string nuevoEstado)
        {
            try
            {
                return repo.ActualizarCampo(nombreUsuario, 4, nuevoEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar estado: " + ex.Message);
            }
        }

        // --- Metodo para cambiar rol de usuario --- \\\
        public bool CambiarRolUsuario(string nombreUsuario, string nuevoRol)
        {
            try
            {
                return repo.ActualizarCampo(nombreUsuario, 3, nuevoRol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar rol: " + ex.Message);
            }
        }

        // --- Metodo para verificar existencia de gmail --- \\\
        public bool GmailExiste(string gmail)
        {
            var usuarios = ObtenerTodosLosUsuarios();

            foreach (var usuario in usuarios)
            {
                if (usuario.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // --- Metodo para eliminar usuario --- \\\
        public bool EliminarUsuario(string nombreUsuario)
        {
            try
            {
                return repo.Eliminar(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
}