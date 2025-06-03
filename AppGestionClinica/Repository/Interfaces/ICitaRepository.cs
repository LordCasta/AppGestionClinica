using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface ICitaRepository
    {
        void Agregar(Cita cita);
        List<Cita> ObtenerTodos();
        List<TimeSpan> ObtenerHorasOcupadas(int doctorId, DateTime fecha);
        List<dynamic> ObtenerPorDoctor(int doctorId);
        List<dynamic> ObtenerPorPaciente(int pacienteId);
        List<Paciente> ObtenerPacientesConCitaDelDoctor(int doctorId);
        void Actualizar(Cita cita);
        void Eliminar(int id);
    }
}
