using Business.BaseClasses;
using Business.Interfaces;
using CommonSolution.Dtos;

namespace Business.Strategies.PagoConcreteStrategies
{
    public class Efectivo : Pago, IPago
    {
        public bool procesarPago(FacturaDto factura)
        {
            return true;
        }
    }
}
