using Business.BaseClasses;
using Business.Interfaces;
using CommonSolution.Dtos;

namespace Business.Strategies.PagoConcreteStrategies
{
    public class Efectivo : Pago, IPago
    {
        public double calcularMontoFinal(double monto)
        {
            double descuento = monto * 0.5;
            double montoFinal = monto - descuento;
            return montoFinal;
        }

        public bool procesarPago(FacturaDto factura)
        {
            return true;
        }
    }
}
