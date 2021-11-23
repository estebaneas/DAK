using Business.BaseClasses;
using Business.Interfaces;
using CommonSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Strategies.PagoConcreteStrategies
{
    public class Visa : Pago, IPago
    {
        public bool procesarPago(FacturaDto factura)
        {
            throw new NotImplementedException();
        }
    }
}
