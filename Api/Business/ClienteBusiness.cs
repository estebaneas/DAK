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
        private ClienteRepository _clienteRepository;
        public ClienteBusiness()
        {
            this._clienteRepository = new ClienteRepository();
        }
        public bool AltaCliente(ClienteDto clienteDto)
        {
            bool response = false;
            this._clienteRepository.registrarCliente(clienteDto);

            if (clienteDto.Tipo_documento == 0 /* CERO ES RUT*/)
            {
                response = this._clienteRepository.registrarEmpresa(clienteDto.Empresa);
            }
            else
            {
                response = this._clienteRepository.registrarPersona(clienteDto.Persona);
            }

            return response;
        }
    }
}
