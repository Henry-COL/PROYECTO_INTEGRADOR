using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Enums;
using GeoIntegral.Models;

namespace GeoIntegral.Controller
{
    public class UsuarioController
    {
        private string rutaUsuarios = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Usuarios.csv"));
        public bool RegistrarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                string linea = $"{nuevoUsuario.Nombre_Usuario};{nuevoUsuario.PasswordHash};{nuevoUsuario.Gmail};{nuevoUsuario.Rol};{nuevoUsuario.Estado}{Environment.NewLine}";
                File.AppendAllText(rutaUsuarios, linea);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
                return false;
            }
        }

        public Usuario Autenticar(string usuario, string password)
        {
            if (!File.Exists(rutaUsuarios)) return null;

            try
            {
                var lineas = File.ReadAllLines(rutaUsuarios).Skip(1);

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    string[] datos = linea.Split(';');

                    if (datos[0] == usuario && datos[1] == password)
                    {
                        RolUsuario rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), datos[3]);
                        EstadoUsuario estado = (EstadoUsuario)Enum.Parse(typeof(EstadoUsuario), datos[4]);

                        if (estado == EstadoUsuario.Inactivo)
                        {
                            MessageBox.Show("Tu cuenta está inactiva. Contacta al administrador.",
                                "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }

                        return new Usuario(datos[0], datos[1], datos[2], rol, estado);
                    }
                }

                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer base de datos: " + ex.Message);
            }

            return null;
        }

        public bool UsuarioExiste(string nombreUsuario)
        {
            if (!File.Exists(rutaUsuarios)) return false;

            var lineas = File.ReadAllLines(rutaUsuarios).Skip(1);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(';');

                if (datos[0] == nombreUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        public bool VerificarUsuarioYGmail(string nombreUsuario, string gmail)
        {
            if (!File.Exists(rutaUsuarios)) return false;

            var lineas = File.ReadAllLines(rutaUsuarios).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) 
                {
                    continue;
                }
                
                string[] datos = linea.Split(';');

                if (datos[0] == nombreUsuario && datos[2] == gmail)
                {
                    if (datos[4] == "Inactivo")
                    {
                        MessageBox.Show("Tu cuenta está inactiva. Contacta al administrador.",
                            "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return true;
                }

            }

            return false;
        }

        public bool CambiarContrasena(string nombreUsuario, string nuevaContrasena)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaUsuarios);

                for (int i = 1; i < lineas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                    string[] datos = lineas[i].Split(';');

                    if (datos[0] == nombreUsuario)
                    {
                        datos[1] = nuevaContrasena;
                        lineas[i] = string.Join(";", datos);
                        break;
                    }
                }

                File.WriteAllLines(rutaUsuarios, lineas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message);
                return false;
            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            var lista = new List<Usuario>();
            if (!File.Exists(rutaUsuarios)) 
            {
                return lista;
            }

            var lineas = File.ReadAllLines(rutaUsuarios).Skip(1);
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(';');

                RolUsuario rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), datos[3].Trim());
                EstadoUsuario estado = (EstadoUsuario)Enum.Parse(typeof(EstadoUsuario), datos[4].Trim());

                lista.Add(new Usuario(datos[0], datos[1], datos[2], rol, estado));
            }
            return lista;
        }
    }
}