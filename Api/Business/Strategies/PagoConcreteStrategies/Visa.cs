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
        public double calcularMontoFinal(double monto)
        {
            double descuento = monto * 0.10;
            double montoFinal = monto - descuento;
            return montoFinal;
        }

        public bool procesarPago(FacturaDto factura)
        {
            return true;
        }
    }
}
