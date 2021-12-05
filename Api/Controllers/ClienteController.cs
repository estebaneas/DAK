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
        [ActionName("RegistrarCliente")]
        public IHttpActionResult RegistrarCliente([FromBody] ClienteDto clienteDto)
        {
            bool result = this._clienteBusiness.AltaCliente(clienteDto);
            if (result != false)
            {
                return Created("AltaCliente", true);
            }
            else
            {
                return Conflict();
            }
        }

        [HttpGet]
        [ActionName("BuscarCliente")]
        public List<ClienteDto> buscarCliente(string busqueda)
        {
            return this._clienteBusiness.buscarCliente(busqueda);
        }

        [HttpGet]
        [ActionName("ListaCliente")]
        public List<ClienteDto> listaCliente()
        {
            return this._clienteBusiness.listaCliente();
        }
    }
}