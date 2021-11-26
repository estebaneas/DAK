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
        FacturaBusiness facutraBs;
        FacturaController()
        {
            this.facutraBs = new FacturaBusiness();
        }

        [HttpPost]
        [ActionName ("PagarFactura")]
        public FacturaDto PagaarFactura([FromBody] FacturaDto factura)
        {
            return  this.facutraBs.pagarFactura(factura);
        }

    }
}