using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Entities
{
    public class Cita
    {
        public int CitaID { get; set; }
        public int PacienteID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; } // Pendiente, Completada, Cancelada
    }
}
