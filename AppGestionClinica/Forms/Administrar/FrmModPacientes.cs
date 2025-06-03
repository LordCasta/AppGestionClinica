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
    public partial class FrmModPacientes : Form
    {
        private readonly UnitOfWork _uof = new UnitOfWork();
        private int? pacienteSeleccionadoId = null;

        public FrmModPacientes()
        {
            InitializeComponent();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            dgvPacientes.Columns.Clear();
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = _uof.Pacientes.ObtenerTodos();

            var btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvPacientes.Columns.Add(btnEditar);

            var btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvPacientes.Columns.Add(btnEliminar);

            dgvPacientes.ClearSelection();
            dgvPacientes.CellClick -= dgvPacientes_CellClick;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvPacientes.Rows[e.RowIndex];
            pacienteSeleccionadoId = Convert.ToInt32(fila.Cells["PacienteID"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            dtpFechaNac.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();

            if (dgvPacientes.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                var confirmar = MessageBox.Show("¿Eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    _uof.Pacientes.Eliminar(pacienteSeleccionadoId.Value);
                    MessageBox.Show("Paciente eliminado.");
                    LimpiarFormulario();
                    CargarPacientes();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            var paciente = new Paciente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNac.Value,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            if (pacienteSeleccionadoId == null)
            {
                _uof.Pacientes.Agregar(paciente);
                MessageBox.Show("Paciente agregado.");
            }
            else
            {
                paciente.PacienteID = pacienteSeleccionadoId.Value;
                _uof.Pacientes.Actualizar(paciente);
                MessageBox.Show("Paciente actualizado.");
            }

            LimpiarFormulario();
            CargarPacientes();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNac.Value = DateTime.Today;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            pacienteSeleccionadoId = null;
            dgvPacientes.ClearSelection();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmAdmin().Show();
        }
    }
}
