using GeoIntegral.Models;
using GeoIntegral.Controller; // Asegúrate de importar el controlador
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class User_Screen : Form, ICerrable
    {
        public event EventHandler VentanaCerrada;
        private Usuario _usuarioSesion;
        // Instanciamos el controlador para manejar la lógica
        private UsuarioController _usuarioController = new UsuarioController();

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
                return correo;
            }

            string[] partes = correo.Split('@');
            string usuario = partes[0];
            string dominio = partes[1];

            if (usuario.Length > 1)
            {
                string primeraLetra = usuario.Substring(0, 1);
                string asteriscos = new string('*', usuario.Length - 1);

                return $"{primeraLetra}{asteriscos}@{dominio}";
            }

            return $"*@{dominio}";
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (_usuarioSesion == null)
            {
                MessageBox.Show("Error: La sesión del usuario es nula en esta pantalla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Cambiar Contraseña",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 350, Text = $"Nueva contraseña para {_usuarioSesion.Nombre_Usuario}:" };
            TextBox txtNuevaPassword = new TextBox() { Left = 20, Top = 45, Width = 340, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "Guardar", Left = 150, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            Button cancellation = new Button() { Text = "Cancelar", Left = 260, Width = 100, Top = 90, DialogResult = DialogResult.Cancel };

            prompt.AcceptButton = confirmation;
            prompt.Controls.AddRange(new Control[] { textLabel, txtNuevaPassword, confirmation, cancellation });

            if (prompt.ShowDialog(this) == DialogResult.OK)
            {
                string nuevaContrasena = txtNuevaPassword.Text.Trim();

                if (string.IsNullOrEmpty(nuevaContrasena))
                {
                    MessageBox.Show("No puedes poner una contraseña vacía.", "Validación");
                    return;
                }

                try
                {
                    bool exito = _usuarioController.CambiarContrasena(_usuarioSesion.Nombre_Usuario, nuevaContrasena);

                    if (exito)
                    {
                        // ¡MUY IMPORTANTE! Si el usuario sigue logueado, actualizamos su hash en memoria 
                        // para que coincida con lo que acabamos de guardar.
                        _usuarioSesion.PasswordHash = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);

                        MessageBox.Show("¡Contraseña cambiada con éxito en el archivo Usuarios.csv!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si entra aquí, significa que el repositorio leyó el archivo pero NO encontró el nombre de usuario escrito igual.
                        MessageBox.Show($"No se encontró al usuario '{_usuarioSesion.Nombre_Usuario}' dentro del archivo CSV. Revisa las mayúsculas o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error crítico en el proceso: {ex.Message}", "Error catastrófico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_App_Click(object sender, EventArgs e)
        {
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
        }
    }
}