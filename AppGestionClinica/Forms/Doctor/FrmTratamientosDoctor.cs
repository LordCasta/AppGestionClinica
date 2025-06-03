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

namespace AppGestionClinica.Forms.Doctor
{
    public partial class FrmTratamientosDoctor : Form
    {
        private readonly UnitOfWork _uow = new UnitOfWork();
        private readonly int _doctorId;

        public FrmTratamientosDoctor(int doctorId)
        {
            InitializeComponent();
            _doctorId = doctorId;
            CargarPacientes();
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
        }

        private void CargarPacientes()
        {
            var pacientes = _uow.Citas.ObtenerPacientesConCitaDelDoctor(_doctorId);
            cmbPaciente.DataSource = pacientes;
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "PacienteID";
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedItem is Paciente paciente)
                CargarTratamientos(paciente.PacienteID);
        }

        private void CargarTratamientos(int pacienteId)
        {
            dgvTratamientos.DataSource = null;
            dgvTratamientos.DataSource = _uow.Tratamientos.ObtenerPorPaciente(pacienteId);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedItem == null ||
               string.IsNullOrWhiteSpace(txtTipo.Text) ||
               string.IsNullOrWhiteSpace(txtDuracion.Text) ||
               string.IsNullOrWhiteSpace(txtCosto.Text) )
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtDuracion.Text, out int duracion) ||
                !decimal.TryParse(txtCosto.Text, out decimal costo) )
            {
                MessageBox.Show("Duración, costo y saldo deben ser valores válidos.");
                return;
            }

            var tratamiento = new Tratamiento
            {
                PacienteID = ((Paciente)cmbPaciente.SelectedItem).PacienteID,
                TipoTratamiento = txtTipo.Text.Trim(),
                FechaInicio = dtpFechaInicio.Value.Date,
                Duracion = duracion,
                CostoTotal = costo,
                SaldoPendiente = costo // Inicialmente el saldo pendiente es igual al costo total
            };

            _uow.Tratamientos.Agregar(tratamiento);
            MessageBox.Show("Tratamiento registrado.");

            Limpiar();
            CargarTratamientos(tratamiento.PacienteID);
        }

        private void Limpiar()
        {
            txtTipo.Clear();
            txtDuracion.Clear();
            txtCosto.Clear();
            dtpFechaInicio.Value = DateTime.Today;
        }
    }
}
