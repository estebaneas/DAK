using Business.BusinessCollection;
using CommonSolution.Dtos;
using CommonSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Business;

namespace Api.Controllers
{
    public class PaqueteController : ApiController
    {
        PaqueteBusiness PaqueteBs ;
        public PaqueteController()
        {
            this.PaqueteBs = new PaqueteBusiness();
        }

        [HttpPost]
        [ActionName("RegistrarPaquete")]
        public PaqueteDto RegistrarPaquete([FromBody]PaqueteDto paquete)
        {
            return this.PaqueteBs.registrarPaquete(paquete);
        }
        

    }
}