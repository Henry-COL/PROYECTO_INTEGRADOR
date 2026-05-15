using GeoIntegral.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    string[] datos = linea.Split(';');

                    if (datos[0] == usuario && datos[2] == password)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer base de datos: " + ex.Message);
            }

            return null;
        }
    }
}
