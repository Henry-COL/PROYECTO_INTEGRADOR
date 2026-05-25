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

        public bool RegistrarUsuario(Usuario nuevoUsuario)
        {
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

        public bool UsuarioExiste(string nombreUsuario)
        {
            foreach (var datos in repo.ObtenerLineas())
            {
                if (datos[0].Trim() == nombreUsuario.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        public bool VerificarUsuarioYGmail(string nombreUsuario, string gmail)
        {
            try
            {
                foreach (var datos in repo.ObtenerLineas())
                {
                    if (datos[0].Trim() == nombreUsuario.Trim() && datos[2].Trim() == gmail.Trim())
                    {
                        // Corrección menor: Validamos contra el Enum o ignorando mayúsculas/minúsculas
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
    }
}