using Business;
using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Api.Controllers
{
    public class FacturaController : ApiController
    {
        private readonly FacturaBusiness facutraBs;
        FacturaController()
        {
            this.facutraBs = new FacturaBusiness();
        }

        [HttpPost]
        [ActionName ("PagarFactura")]
        public FacturaDto PagarFactura([FromBody] FacturaDto factura)
        {
            return  this.facutraBs.pagarFactura(factura);
        }

        [HttpGet]
        [ActionName ("CalcularPrecio")]
        public double calcularMonto(int distancia, double peso, int grupo)
        {
            return this.facutraBs.calcularPrecio(distancia, peso, grupo);
        }

        [HttpGet]
        [ActionName ("CalcularPrecioFinal")]
        public double calcularMontoFinal([FromBody] FacturaDto factura)
        {
            return this.facutraBs.calcularMontoFinal(factura).MontoFinal;
        }

    }
}