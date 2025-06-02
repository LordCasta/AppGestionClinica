using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Entities
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public int? DoctorID { get; set; } // Relación opcional con Doctor, si es un doctor
}
}
