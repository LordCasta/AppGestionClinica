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
    public partial class FrmCitas : Form
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public FrmCitas()
        {
            InitializeComponent();
            CargarDoctores();
            CargarPacientes();
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
        }

        private void CargarDoctores()
        {
            cmbDoctor.DataSource = _uow.Doctores.ObtenerTodos();
            cmbDoctor.DisplayMember = "Nombre";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void CargarPacientes()
        {
            cmbPaciente.DataSource = _uow.Pacientes.ObtenerTodos();
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "PacienteID";
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHorasDisponibles();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarHorasDisponibles();
        }


        private void CargarHorasDisponibles()
        {
            if (cmbDoctor.SelectedItem == null) return;

            int doctorId = ((Entities.Doctor)cmbDoctor.SelectedItem).DoctorID;
            DateTime fecha = dtpFecha.Value.Date;

            var horasOcupadas = _uow.Citas.ObtenerHorasOcupadas(doctorId, fecha);

            cmbHora.Items.Clear();
            for (int h = 8; h < 17; h++) // De 8 a 4 de la tarde
            {
                var hora = new TimeSpan(h, 0, 0);
                if (!horasOcupadas.Contains(hora))
                    cmbHora.Items.Add(hora.ToString(@"hh\:mm"));
            }

            if (cmbHora.Items.Count > 0)
                cmbHora.SelectedIndex = 0;
            else
                MessageBox.Show("No hay horarios disponibles para este día.");
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedItem == null || cmbDoctor.SelectedItem == null || cmbHora.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            var cita = new Cita
            {
                PacienteID = ((Paciente)cmbPaciente.SelectedItem).PacienteID,
                DoctorID = ((Entities.Doctor)cmbDoctor.SelectedItem).DoctorID,
                Fecha = dtpFecha.Value.Date,
                Hora = TimeSpan.Parse(cmbHora.SelectedItem.ToString()),
                Estado = "Programada"
            };

            _uow.Citas.Agregar(cita);
            MessageBox.Show("Cita registrada.");
            CargarHorasDisponibles();
        }

        private void lblVerCita_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmVerCitas().ShowDialog();
        }
    }
}
