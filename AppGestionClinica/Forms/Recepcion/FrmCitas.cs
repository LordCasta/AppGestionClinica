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
            try
            {
                CargarDoctores();
                CargarPacientes();
                dtpFecha.MinDate = DateTime.Today;
                dtpFecha.ValueChanged += dtpFecha_ValueChanged;
                cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario: " + ex.Message);
            }
        }

        private void CargarDoctores()
        {
            try
            {
                cmbDoctor.DataSource = _uow.Doctores.ObtenerTodos();
                cmbDoctor.DisplayMember = "Nombre";
                cmbDoctor.ValueMember = "DoctorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message);
            }
        }

        private void CargarPacientes()
        {
            try
            {
                cmbPaciente.DataSource = _uow.Pacientes.ObtenerTodos();
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "PacienteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarHorasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el doctor: " + ex.Message);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarHorasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la fecha: " + ex.Message);
            }
        }

        private void CargarHorasDisponibles()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las horas disponibles: " + ex.Message);
            }
        }

        private bool ComprobarPazySalvo()
        {
            try
            {
                var paciente = (Paciente)cmbPaciente.SelectedItem;
                var tratamientos = _uow.Tratamientos.ObtenerPorPaciente(paciente.PacienteID);
                var conSaldo = tratamientos.FindAll(t => t.SaldoPendiente > 0);
                if (conSaldo.Count > 0)
                {
                    MessageBox.Show("El paciente tiene tratamientos pendientes de pago. No se puede programar la cita.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar paz y salvo: " + ex.Message);
                return false;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
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

                if (!ComprobarPazySalvo())
                    return;

                _uow.Citas.Agregar(cita);
                MessageBox.Show("Cita registrada.");
                CargarHorasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar la cita: " + ex.Message);
            }
        }

        private void lblVerCita_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                new FrmVerCitas().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de citas: " + ex.Message);
            }
        }
    }
}
