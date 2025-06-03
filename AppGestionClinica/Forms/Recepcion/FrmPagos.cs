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
    public partial class FrmPagos : Form
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public FrmPagos()
        {
            InitializeComponent();
            try
            {
                CargarPacientes();
                cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
                cmbTratamiento.SelectedIndexChanged += cmbTratamiento_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}");
            }
        }

        private void CargarPacientes()
        {
            try
            {
                var pacientes = _uow.Pacientes.ObtenerTodos();
                cmbPaciente.DataSource = pacientes;
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "PacienteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}");
            }
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaciente.SelectedItem is Paciente paciente)
                {
                    var tratamientos = _uow.Tratamientos.ObtenerPorPaciente(paciente.PacienteID);
                    var conSaldo = tratamientos.FindAll(t => t.SaldoPendiente > 0);
                    cmbTratamiento.DataSource = conSaldo;
                    cmbTratamiento.DisplayMember = "TipoTratamiento";
                    cmbTratamiento.ValueMember = "TratamientoID";

                    if (conSaldo.Count == 0)
                    {
                        lblSaldo.Text = "No hay tratamientos pendientes";
                        dgvPagos.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
            }
        }

        private void cmbTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTratamiento.SelectedItem is Tratamiento t)
                {
                    lblSaldo.Text = $"Saldo pendiente: {t.SaldoPendiente:C}";
                    dgvPagos.DataSource = _uow.Pagos.ObtenerPorTratamiento(t.TratamientoID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los pagos: {ex.Message}");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTratamiento.SelectedItem is not Tratamiento tratamiento)
                {
                    MessageBox.Show("Seleccione un tratamiento válido.");
                    return;
                }

                if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMetodo.Text))
                {
                    MessageBox.Show("Ingrese el método de pago.");
                    return;
                }

                if (monto > tratamiento.SaldoPendiente)
                {
                    MessageBox.Show("El monto excede el saldo pendiente.");
                    return;
                }

                var pago = new Pago
                {
                    TratamientoID = tratamiento.TratamientoID,
                    FechaPago = DateTime.Today,
                    Monto = monto,
                    MetodoPago = txtMetodo.Text.Trim()
                };

                _uow.Pagos.Agregar(pago);
                tratamiento.SaldoPendiente -= monto;
                _uow.Tratamientos.ActualizarSaldo(tratamiento.TratamientoID, tratamiento.SaldoPendiente);

                MessageBox.Show("Pago registrado correctamente.");
                txtMonto.Clear();
                txtMetodo.Clear();
                cmbPaciente_SelectedIndexChanged(null, null); // Recarga todo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el pago: {ex.Message}");
            }
        
        }
    }
}
