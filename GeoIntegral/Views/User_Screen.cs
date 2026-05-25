using GeoIntegral.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class User_Screen : Form
    {
        private Usuario _usuarioSesion;
        public User_Screen(Usuario usuario, Size tamanoPanel)
        {
            InitializeComponent();
            this._usuarioSesion = usuario;
            this.Size = tamanoPanel;

            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            if (_usuarioSesion != null)
            {
                lblNombre_Usuario.Text = _usuarioSesion.Nombre_Usuario;
                lblGmail_Usuario.Text = EnmascararCorreo(_usuarioSesion.Gmail);
            }
        }

        private string EnmascararCorreo(string correo)
        {
            if (string.IsNullOrEmpty(correo) || !correo.Contains("@"))
            {
                return correo; // Retorna el valor original si está vacío o no es un correo válido
            }

            // Dividimos el correo en dos partes: [0] usuario (henzo) y [1] dominio (gmail.com)
            string[] partes = correo.Split('@');
            string usuario = partes[0];
            string dominio = partes[1];

            // Si el usuario tiene más de 1 carácter, dejamos la primera letra y tapamos el resto
            if (usuario.Length > 1)
            {
                string primeraLetra = usuario.Substring(0, 1);
                string asteriscos = new string('*', usuario.Length - 1);

                return $"{primeraLetra}{asteriscos}@{dominio}";
            }

            // Si por alguna razón el usuario tiene solo 1 letra (ej: h@gmail.com), solo le ponemos asteriscos al lado
            return $"*@{dominio}";
        }
    }
}