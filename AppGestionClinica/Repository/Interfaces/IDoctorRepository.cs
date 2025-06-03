using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface IDoctorRepository
    {
        void Agregar(Doctor d);
        List<Doctor> ObtenerTodos();
        Doctor ObtenerPorId(int id);
        void Actualizar(Doctor d);
        void Eliminar(int id);
    }
}
