using AppGestionClinica.Data;
using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionClinica.Forms.Recepcion
{
    public partial class FrmVerCitas : Form
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public FrmVerCitas()
        {
            InitializeComponent();
            try
            {
                cmbDoctor.DataSource = _uow.Doctores.ObtenerTodos();
                cmbDoctor.DisplayMember = "Nombre";
                cmbDoctor.ValueMember = "DoctorID";

                cmbPaciente.DataSource = _uow.Pacientes.ObtenerTodos();
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "PacienteID";

                cmbDoctor.SelectedIndexChanged += (s, ev) =>
                {
                    try
                    {
                        CargarCitasPorDoctor();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar citas por doctor: " + ex.Message);
                    }
                };

                cmbPaciente.SelectedIndexChanged += (s, ev) =>
                {
                    try
                    {
                        CargarCitasPorPaciente();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar citas por paciente: " + ex.Message);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario de citas: " + ex.Message);
            }
        }

        private void CargarCitasPorDoctor()
        {
            try
            {
                if (cmbDoctor.SelectedItem is Entities.Doctor doctor)
                {
                    dgvDoctores.DataSource = _uow.Citas.ObtenerPorDoctor(doctor.DoctorID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener citas del doctor: " + ex.Message);
            }
        }

        private void CargarCitasPorPaciente()
        {
            try
            {
                if (cmbPaciente.SelectedItem is Paciente paciente)
                {
                    dgvPacientes.DataSource = _uow.Citas.ObtenerPorPaciente(paciente.PacienteID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener citas del paciente: " + ex.Message);
            }
        }
    }
}
