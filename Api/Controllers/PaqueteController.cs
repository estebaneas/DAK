using Business.BusinessCollection;
using CommonSolution.Dtos;
using CommonSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Business;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class PaqueteController : ApiController
    {
        private readonly PaqueteBusiness _paqueteBusiness ;
        public PaqueteController()
        {
            this._paqueteBusiness = new PaqueteBusiness();
        }

        [HttpPost]
        public PaqueteDto RegistrarPaquete([FromBody]PaqueteDto paquete)
        {
            return this._paqueteBusiness.AltaPaquete(paquete);
        }
        

    }
}