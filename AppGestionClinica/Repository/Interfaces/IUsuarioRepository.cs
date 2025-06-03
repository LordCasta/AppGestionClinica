using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        void Agregar(Usuario usuario);
        void AgregarDoctor(Usuario u, int doctorId);
        Usuario ObtenerPorCredenciales(string user, string pass);
        List<Usuario> ObtenerTodos();
        void Actualizar(Usuario usuario);
        void Eliminar(int id);
    }
}
