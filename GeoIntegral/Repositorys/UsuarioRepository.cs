using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GeoIntegral.Enums;
using GeoIntegral.Models;

namespace GeoIntegral.Repositorys
{
    public class UsuarioRepository
    {
        private string rutaUsuarios;

        public UsuarioRepository()
        {
            rutaUsuarios = ResolveRutaUsuarios();
        }

        private string ResolveRutaUsuarios()
        {
            // Intentamos varias ubicaciones comunes donde puede encontrarse la carpeta DataBase
            try
            {
                var candidate1 = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "Usuarios.csv"));
                var candidate2 = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "DataBase", "Usuarios.csv"));

                if (File.Exists(candidate1)) return candidate1;
                if (File.Exists(candidate2)) return candidate2;

                // Si no existe, devolvemos candidate1 y creamos la carpeta cuando sea necesario en Agregar
                return candidate1;
            }
            catch
            {
                // Fallback simple
                return Path.Combine("DataBase", "Usuarios.csv");
            }
        }

        public bool Agregar(Usuario nuevoUsuario)
        {
            // Asegurar que exista el directorio
            var dir = Path.GetDirectoryName(rutaUsuarios);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            // Si no existe el archivo, crear encabezado
            if (!File.Exists(rutaUsuarios))
            {
                string encabezado = $"Nombre_Usuario;PasswordHash;Gmail;Rol;Estado{Environment.NewLine}";
                File.WriteAllText(rutaUsuarios, encabezado);
            }

            string linea = $"{nuevoUsuario.Nombre_Usuario};{nuevoUsuario.PasswordHash};{nuevoUsuario.Gmail};{nuevoUsuario.Rol};{nuevoUsuario.Estado}{Environment.NewLine}";
            File.AppendAllText(rutaUsuarios, linea);
            return true;
        }

        // UsuarioRepository.cs
        public bool Eliminar(string nombreUsuario)
        {
            if (!File.Exists(rutaUsuarios)) return false;

            var lineas = File.ReadAllLines(rutaUsuarios).ToList();
            var encabezado = lineas[0];
            var datosFiltrados = lineas.Skip(1)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Where(l => l.Split(';')[0].Trim() != nombreUsuario.Trim())
                .ToList();

            var resultado = new List<string> { encabezado };
            resultado.AddRange(datosFiltrados);

            File.WriteAllLines(rutaUsuarios, resultado);
            return true;
        }


        public List<string[]> ObtenerLineas()
        {
            if (!File.Exists(rutaUsuarios))
            {
                return new List<string[]>();
            }

            return File.ReadAllLines(rutaUsuarios)
                       .Skip(1)
                       .Where(l => !string.IsNullOrWhiteSpace(l))
                       .Select(l => l.Split(';'))
                       .ToList();
        }

        public bool ActualizarCampo(string nombreUsuario, int indiceCampo, string nuevoValor)
        {
            if (!File.Exists(rutaUsuarios))
            {
                return false;
            }

            var lineas = File.ReadAllLines(rutaUsuarios);
            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                string[] datos = lineas[i].Split(';');
                if (datos[0] == nombreUsuario)
                {
                    datos[indiceCampo] = nuevoValor;
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(rutaUsuarios, lineas);
            return true;
        }
    }
}