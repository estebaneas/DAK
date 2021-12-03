using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.Strategies.GrupoConcreteStrategies;
using Business.Strategies.PagoConcreteStrategies;
using CommonSolution.Dtos;
using DataAccess.Repositories;

namespace Business
{
    public class FacturaBusiness
    {
        private readonly FacturaRepository FacturaRepo;
        public FacturaBusiness()
        {
            this.FacturaRepo = new FacturaRepository();
        }

        public FacturaDto calcularMontoFinal(FacturaDto factura)
        {
            IPago pago;
            switch (factura.TipoPago)
            {
                case 1:
                    pago = new Debito();
                    break;
                case 2:
                    pago = new Visa();
                    break;
                case 3:
                    pago = new MercadoPago();
                    break;
                default:
                    pago = new Efectivo();
                    break;
            }

            factura.MontoFinal = pago.calcularMontoFinal(factura.Monto);

            return factura;
        }

        public double calcularPrecio(int distancia, double peso, int grupo)
        {
            double precio;
            IGrupo iGrupo;
            switch (grupo)
            {
                case 1:
                    iGrupo = new Peso();
                    break;
                case 2:
                    iGrupo = new DistanciaPeso();
                    break;
                default:
                    iGrupo = new Fijo();
                    break;
            }

            precio = iGrupo.calcularPrecio(distancia, peso);
            return precio;
        }

        public FacturaDto pagarFactura(FacturaDto factura)
        {
            IPago pago;
            bool aprobado;
            switch (factura.TipoPago)
            {
                case 1:
                    pago = new Debito();
                    break;
                case 2:
                    pago = new Visa();
                    break;
                case 3:
                    pago = new MercadoPago();
                    break;
                default:
                    pago = new Efectivo();
                    break;
            }

            aprobado = pago.procesarPago(factura);
            if (aprobado)
            {
                factura.FechaDepago = DateTime.Now;
                return this.FacturaRepo.registrarFacutra(factura);
            }
            else
            {
                return null;
            }
        }
    }
}
