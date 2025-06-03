using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface IPacienteRepository
    {
        void Agregar(Paciente p);
        List<Paciente> ObtenerTodos();
        Paciente ObtenerPorId(int id);
        void Actualizar(Paciente p);
        void Eliminar(int id);
    }
}
