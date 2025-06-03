using AppGestionClinica.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Factory
{
    public class MenuFactory
    {
        public static Form MenuRol(string rol)
        {
            return rol switch
            {
                "Administrador" => new FrmAdmin(),
                "Recepcionista" => new frmRecepcionista(),
                "Doctor" => new FrmDoctor(),
                _ => throw new Exception("Rol no válido")
            };
        }
    }
}
