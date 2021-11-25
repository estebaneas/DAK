using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class FacturaDto
    {
        public int Numero { get; set; }
        public double Monto { get; set; }
        public DateTime FechaDepago { get; set; }
        public double MontoFinal { get; set; }
        public int TipoPago { get; set; }
    }
}
