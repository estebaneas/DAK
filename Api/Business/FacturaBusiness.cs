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
        public Mensaje pagarFactura(FacturaDto factura)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.descripcion = "{Numero = numero de factura},{Bool = factura aprobada = true, no aprobada = fase}";
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
                mensaje.boolean = true;
                factura.FechaDepago = DateTime.Now;
                int? numFactura = this.FacturaRepo.registrarFacutra(factura);
                if(numFactura!=null)
                {
                    mensaje.numero = numFactura;
                }
                else
                {
                    mensaje.colErrores.Add("Hubo un problema con la base de datos al ingresar factura");
                }
            }
            else
            {
                mensaje.colErrores.Add("No se pudo completar el pago");
            }
            return mensaje;
        }
    }
}
