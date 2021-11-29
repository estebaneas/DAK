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
    public class Debito : Pago, IPago
    {
        public double calcularMontoFinal(double monto)
        {
            return monto;
        }

        public bool procesarPago(FacturaDto factura)
        {
            return true;
        }
    }
}
