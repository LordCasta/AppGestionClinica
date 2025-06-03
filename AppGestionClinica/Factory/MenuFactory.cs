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
            try
            {
                if (rol == "Doctor" && (!doctorId.HasValue || doctorId <= 0))
                    throw new Exception("DoctorID requerido para el rol Doctor");

                return rol switch
                {
                    "Administrador" => new FrmAdmin(),
                    "Recepcionista" => new frmRecepcionista(),
                    "Doctor" => new FrmDoctor(doctorId.Value),
                    _ => throw new Exception("Rol no válido")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar menú: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Form(); // Devuelve un formulario vacío para evitar que el flujo reviente
            }
        }
    }
}
