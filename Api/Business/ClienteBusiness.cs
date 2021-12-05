using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteBusiness()
        {
            this._clienteRepository = new ClienteRepository();
        }
        public bool AltaCliente(ClienteDto clienteDto)
        {
            var response = false;
            response = this._clienteRepository.registrarCliente(clienteDto);

            if(response == true)
            {
                if (clienteDto.Tipo_documento == 0 /* CERO ES RUT*/)
                {
                    response = this._clienteRepository.registrarEmpresa(clienteDto.Empresa);
                }
                else
                {
                    response = this._clienteRepository.registrarPersona(clienteDto.Persona);
                }
            }

            return response;
        }

        public List<string> buscarCliente(string busqueda)
        {
            List<string> documentosCliente = new List<string>();
            var clienteResult = this._clienteRepository.buscarClientes(busqueda);
            clienteResult.ForEach(element => documentosCliente.Add(element.Documento));
            return documentosCliente;
        }

        public int? buscarClienteGrupo(string busqueda)
        {  
            return this._clienteRepository.buscarClientesGrupo(busqueda);
            
        }

        public List<ClienteDto> listaCliente()
        {
            return this._clienteRepository.listaClientes();
        }
    }
}
