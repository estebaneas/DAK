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
using System.Net;

namespace Api.Controllers
{
    public class PaqueteController : ApiController
    {
        private readonly PaqueteBusiness _paqueteBusiness ;
        public PaqueteController()
        {
            this._paqueteBusiness = new PaqueteBusiness();
        }
        /// <summary>
        /// Se ingresa un nuevo paquete
        /// </summary>
        /// <param name="paquete"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult RegistrarPaquete([FromBody]PaqueteDto paquete)
        {
            var result = this._paqueteBusiness.AltaPaquete(paquete);
            if(result != null)
            {
                return Created("AltaPaquete", result);
            }
            else
            {
                return Conflict();
            }
        }
        

    }
}