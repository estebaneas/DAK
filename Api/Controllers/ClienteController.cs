using Business;
using CommonSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly ClienteBusiness _clienteBusiness;
        public ClienteController()
        {
            this._clienteBusiness = new ClienteBusiness();
        }

        [HttpPost]
        public IHttpActionResult RegistrarCliente([FromBody] ClienteDto clienteDto)
        {
            bool result = this._clienteBusiness.AltaCliente(clienteDto);
            if (result != false)
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