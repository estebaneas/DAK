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
        private ClienteBusiness _clienteBusiness;
        public ClienteController()
        {
            this._clienteBusiness = new ClienteBusiness();
        }

        [HttpPost]
        public bool RegistrarCliente([FromBody] ClienteDto clienteDto)
        {
            return this._clienteBusiness.AltaCliente(clienteDto);
        }
    }
}