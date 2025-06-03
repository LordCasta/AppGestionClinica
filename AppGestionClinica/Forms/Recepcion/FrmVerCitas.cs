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
            cmbDoctor.DataSource = _uow.Doctores.ObtenerTodos();
            cmbDoctor.DisplayMember = "Nombre";
            cmbDoctor.ValueMember = "DoctorID";

            cmbPaciente.DataSource = _uow.Pacientes.ObtenerTodos();
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "PacienteID";

            cmbDoctor.SelectedIndexChanged += (s, ev) => CargarCitasPorDoctor();
            cmbPaciente.SelectedIndexChanged += (s, ev) => CargarCitasPorPaciente();
        }

        private void CargarCitasPorDoctor()
        {
            if (cmbDoctor.SelectedItem is Entities.Doctor doctor)
            {
                dgvDoctores.DataSource = _uow.Citas.ObtenerPorDoctor(doctor.DoctorID);
            }
        }

        private void CargarCitasPorPaciente()
        {
            if (cmbPaciente.SelectedItem is Paciente paciente)
            {
                dgvPacientes.DataSource = _uow.Citas.ObtenerPorPaciente(paciente.PacienteID);
            }
        }
    }
}
