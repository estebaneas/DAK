using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class PaqueteFactura
    {
        public FacturaDto factura { get; set; }
        public PaqueteDto paquete { get; set; }
    }
}
