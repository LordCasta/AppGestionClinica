using AppGestionClinica.Repository;
using AppGestionClinica.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Data
{
    public class UnitOfWork
    {
        public IPacienteRepository Pacientes { get; }
        public IDoctorRepository Doctores { get; }
        public IUsuarioRepository Usuarios { get; }
        public ICitaRepository Citas { get; }
        public ITratamientoRepository Tratamientos { get; }
        public IPagoRepository Pagos { get; }

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
