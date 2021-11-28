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
using Api.Validator.Paquete;

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
            var validator = new PaqueteResourceValidator();
            var validatorResult = validator.Validate(paquete);
            if(!validatorResult.IsValid)
            {
                return BadRequest(validatorResult.ToString());
            }

            var result = this._paqueteBusiness.AltaPaquete(paquete);
            if(result != null)
            {
                return Created("AltaPaquete", true);
            }
            else
            {
                return Conflict();
            }
        }
        

    }
}