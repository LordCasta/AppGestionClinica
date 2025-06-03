using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface IPagoRepository
    {
        void Agregar(Pago p);
        List<Pago> ObtenerPorTratamiento(int tratamientoId);
        decimal ObtenerTotalPagado(int tratamientoId);
        List<Pago> ObtenerTodos();
        void Eliminar(int id);
    }
}
