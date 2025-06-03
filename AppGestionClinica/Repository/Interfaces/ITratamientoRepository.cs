using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface ITratamientoRepository
    {
        void Agregar(Tratamiento t);
        List<Tratamiento> ObtenerTodos();
        List<Tratamiento> ObtenerPorPaciente(int pacienteId);
        void Actualizar(Tratamiento t);
        void ActualizarSaldo(int tratamientoId, decimal nuevoSaldo);
        void Eliminar(int tratamientoId);     
        
    }
}
