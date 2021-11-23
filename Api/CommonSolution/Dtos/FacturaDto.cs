using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class FacturaDto
    {
        public int numero { get; set; }
        public double monto { get; set; }
        public double precioFinal { get; set; }
        public DateTime fechaPago { get; set; }
        public int pago;
    }
}
