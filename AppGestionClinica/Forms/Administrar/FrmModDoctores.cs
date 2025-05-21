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
    public partial class FrmModDoctores : Form
    {
        DoctorRepository repo = new DoctorRepository();
        BindingList<Doctor> listaDoctores;
        private int? doctorSeleccionadoId = null;
        public FrmModDoctores()
        {
            InitializeComponent();
        }

        private void FrmModDoctores_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            #region
            // Cargar especializaciones en el ComboBox
            cmbEspecializacion.Items.Add("General");
            cmbEspecializacion.Items.Add("Cardiología");
            cmbEspecializacion.Items.Add("Dermatología");
            cmbEspecializacion.Items.Add("Ginecología");
            cmbEspecializacion.Items.Add("Pediatría");
            cmbEspecializacion.Items.Add("Psiquiatría");
            cmbEspecializacion.Items.Add("Traumatología");
            #endregion
        }

        private void CargarDoctores()
        {
            listaDoctores = new BindingList<Doctor>(repo.ObtenerTodos());
            dgvDoctores.DataSource = listaDoctores;

            // Opcional: ocultar la columna ID si no quieres editarla
            dgvDoctores.Columns["DoctorID"].ReadOnly = true;

            if (!dgvDoctores.Columns.Contains("Editar"))
            {
                var btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvDoctores.Columns.Add(btnEditar);

                var btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvDoctores.Columns.Add(btnEliminar);
            }



        }

        private void btnCrearDoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbEspecializacion.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            var doctor = new Doctor
            {
                Nombre = txtNombre.Text,
                Especializacion = cmbEspecializacion.Text,
                Telefono = txtTelefono.Text
            };

            repo.Agregar(doctor);
            MessageBox.Show("Doctor agregado.");
            LimpiarFormulario();
            CargarDoctores();
        }

        private void dgvDoctores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvDoctores.Rows[e.RowIndex];
            int doctorId = Convert.ToInt32(fila.Cells["DoctorID"].Value);

            if (dgvDoctores.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                string nuevoNombre = fila.Cells["Nombre"].Value.ToString();
                string nuevaEsp = fila.Cells["Especializacion"].Value.ToString();
                string nuevoTel = fila.Cells["Telefono"].Value.ToString();

                var doctor = new Doctor
                {
                    DoctorID = doctorId,
                    Nombre = nuevoNombre,
                    Especializacion = nuevaEsp,
                    Telefono = nuevoTel
                };

                repo.Actualizar(doctor);
                MessageBox.Show("Doctor actualizado.");
            }
            else if (dgvDoctores.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                var confirmar = MessageBox.Show("¿Eliminar este doctor?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    repo.Eliminar(doctorId);
                    CargarDoctores();
                    MessageBox.Show("Doctor eliminado.");
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            doctorSeleccionadoId = null;
            dgvDoctores.ClearSelection();
        }
    }
}
