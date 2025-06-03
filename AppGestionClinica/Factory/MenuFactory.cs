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
        public static Form MenuRol(string rol, int? doctorId = null)
        {
            return rol switch
            {
                "Administrador" => new FrmAdmin(),
                "Recepcionista" => new frmRecepcionista(),
                "Doctor"  => doctorId.Value > 0 ? new FrmDoctor(doctorId.Value) : throw new Exception("DoctorID requerido para el rol Doctor"),
                _ => throw new Exception("Rol no válido")
            };
        }
    }
}
