using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Entities
{
    public class Pago
    {
        public int PagoID { get; set; }
        public int TratamientoID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } // Efectivo, Tarjeta, Transferencia
    }
}
