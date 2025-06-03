using AppGestionClinica.Data;
using AppGestionClinica.Entities;
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

namespace AppGestionClinica.Forms.Administrar
{
    public partial class FrmModUsuarios : Form
    {
        private readonly UnitOfWork _uof = new UnitOfWork();

        private int? usuarioSeleccionadoId = null;

        public FrmModUsuarios()
        {
            InitializeComponent();
            //Se cargan los roles en el ComboBox al iniciar el formulario
            cmbRol.Items.AddRange(new[] { "Administrador", "Recepcionista", "Doctor" });
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            cmbDoctor.Enabled = false;
            CargarUsuarios();
        }


        //Se habilita o inhabilita el ComboBox de doctores según el rol seleccionado
        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se asegura que cmbDoctor esté instanciado antes de usarlo
            if (cmbDoctor == null || cmbRol.SelectedItem == null) return;

            if (cmbRol.SelectedItem.ToString() == "Doctor")
            {
                cmbDoctor.Enabled = true;
                CargarDoctoresDisponibles();
            }
            else
            {
                cmbDoctor.Enabled = false;
                cmbDoctor.DataSource = null;
                cmbDoctor.SelectedIndex = -1;
            }
        }

        private void CargarDoctoresDisponibles()
        {
            //Se seleccionan los doctores que no tienen un usuario asignado
            var doctores = _uof.Doctores.ObtenerTodos();
            var usuarios = _uof.Usuarios.ObtenerTodos();
            var doctoresConUsuario = usuarios.Where(u => u.DoctorID.HasValue).Select(u => u.DoctorID.Value).ToList();

            var disponibles = doctores.Where(d => !doctoresConUsuario.Contains(d.DoctorID)).ToList();

            cmbDoctor.DataSource = disponibles;
            cmbDoctor.DisplayMember = "Nombre";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _uof.Usuarios.ObtenerTodos();

            var btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvUsuarios.Columns.Add(btnEditar);

            var btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvUsuarios.Columns.Add(btnEliminar);

            dgvUsuarios.ClearSelection();
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex < 0 || e.RowIndex >= dgvUsuarios.Rows.Count) return;

            var fila = dgvUsuarios.Rows[e.RowIndex];
            usuarioSeleccionadoId = Convert.ToInt32(fila.Cells["UsuarioID"].Value);
            txtUsuario.Text = fila.Cells["Username"].Value.ToString();
            txtContraseña.Text = fila.Cells["Password"].Value.ToString();
            cmbRol.SelectedItem = fila.Cells["Rol"].Value.ToString();

            var doctorIdObj = fila.Cells["DoctorID"].Value;
            if (doctorIdObj != DBNull.Value && cmbRol.SelectedItem.ToString() == "Doctor")
            {
                cmbDoctor.Enabled = true;
                CargarDoctoresDisponibles();
                int doctorId = Convert.ToInt32(doctorIdObj);
                cmbDoctor.SelectedValue = doctorId;
            }

            if (dgvUsuarios.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                var confirm = MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _uof.Usuarios.Eliminar(usuarioSeleccionadoId.Value);
                    Limpiar();
                    CargarUsuarios();
                    MessageBox.Show("Usuario eliminado.");
                }
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cmbRol.SelectedIndex = -1;
            cmbDoctor.DataSource = null;
            cmbDoctor.Enabled = false;
            usuarioSeleccionadoId = null;
            dgvUsuarios.ClearSelection();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            var usuario = new Usuario
            {
                Username = txtUsuario.Text.Trim(),
                Password = txtContraseña.Text.Trim(),
                Rol = cmbRol.SelectedItem.ToString(),
                DoctorID = (cmbRol.SelectedItem.ToString() == "Doctor" && cmbDoctor.SelectedItem != null)
                    ? ((Entities.Doctor)cmbDoctor.SelectedItem).DoctorID
                    : (int?)null
            };

            if (usuarioSeleccionadoId == null)
            {
                if (usuario.DoctorID != null)
                {
                    _uof.Usuarios.AgregarDoctor(usuario, usuario.DoctorID.Value);
                }
                else
                {
                    _uof.Usuarios.Agregar(usuario);
                }
                MessageBox.Show("Usuario registrado.");
            }
            else
            {
                usuario.UsuarioID = usuarioSeleccionadoId.Value;
                _uof.Usuarios.Actualizar(usuario);
                MessageBox.Show("Usuario actualizado.");
            }

            Limpiar();
            CargarUsuarios();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmAdmin().ShowDialog();
        }
    }
}
