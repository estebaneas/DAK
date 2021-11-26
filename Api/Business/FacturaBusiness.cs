using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.Strategies.PagoConcreteStrategies;
using CommonSolution.Dtos;
using DataAccess.Repositories;

namespace Business
{
    public class FacturaBusiness
    {
        FacturaRepository FacturaRepo;
        public FacturaBusiness()
        {
            this.FacturaRepo = new FacturaRepository();
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
