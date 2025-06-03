using AppGestionClinica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Data
{
    public class UnitOfWork
    {
        public PacienteRepository Pacientes { get; }
        public DoctorRepository Doctores { get; }
        public UsuarioRepository Usuarios { get; }
        public CitaRepository Citas { get; }
        public TratamientoRepository Tratamientos { get; }
        public PagoRepository Pagos { get; }

        public UnitOfWork()
        {
            Pacientes = new PacienteRepository();
            Doctores = new DoctorRepository();
            Usuarios = new UsuarioRepository();
            Citas = new CitaRepository();
            Tratamientos = new TratamientoRepository();
            Pagos = new PagoRepository();
        }
    }
}
