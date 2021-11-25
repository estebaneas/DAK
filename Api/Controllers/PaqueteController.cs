using Business.BusinessCollection;
using CommonSolution.Dtos;
using CommonSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Api.Controllers
{
    public class PaqueteController : ApiController
    {
        BusinessCollection BColl;
        public PaqueteController()
        {
            this.BColl = new BusinessCollection();
        }

        [HttpPost]
        [ActionName("ProcesarPaquete")]
        public List<Mensaje> Procesar([FromBody]PaqueteFactura PaqueteFactura)
        {
            List<Mensaje> respuestas = new List<Mensaje>();
            Mensaje respuestaFactura = BColl.getFacturaB().pagarFactura(PaqueteFactura.factura);
            respuestas.Add(respuestaFactura);
            bool aprobado = respuestaFactura.boolean;
            if(aprobado)
            {
                respuestas.Add(BColl.getPaqueteB().registrarPaquete(PaqueteFactura.paquete, (int)respuestaFactura.numero));
            }
            return respuestas;
        }
        

    }
}