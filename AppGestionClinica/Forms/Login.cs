using AppGestionClinica.Data;
using AppGestionClinica.Factory;
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
        private readonly UnitOfWork _uof = new UnitOfWork();
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

            var usuario = _uof.Usuarios.ObtenerPorCredenciales(user, password);

            if (usuario != null)
            {
                lblError.Visible = false;
                MessageBox.Show($"Bienvenido {usuario.Username} ({usuario.Rol})", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); 
                
                MenuFactory.MenuRol(usuario.Rol).ShowDialog();

            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
                lblError.Visible = true;
            }
        }
    }
}
