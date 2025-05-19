using AppGestionClinica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppGestionClinica.Forms
{
    public partial class Login : Form
    {
        private readonly UsuarioRepository _usuarioRepo = new UsuarioRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Debe ingresar usuario y contraseña";
                lblError.Visible = true;
                return;
            }

            var usuario = _usuarioRepo.ObtenerPorCredenciales(user, password);

            if (usuario != null)
            {
                lblError.Visible = false;
                // Aquí puedes abrir el formulario principal o realizar otras acciones según el rol del usuario
                MessageBox.Show($"Bienvenido {usuario.Username} ({usuario.Rol})", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Oculta el formulario de login
                // Aquí podrías abrir el formulario principal de la aplicación
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
                lblError.Visible = true;
            }
        }
    }
}
