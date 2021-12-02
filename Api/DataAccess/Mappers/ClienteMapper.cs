using CommonSolution.Dtos;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    public class ClienteMapper
    {

        public Cliente toEntity(ClienteDto entrada)
        {
            Cliente salida = new Cliente();
            salida.Documento = entrada.Documento;
            salida.Tipo_documento = entrada.Tipo_documento;
            salida.Telefono = entrada.Telefono;
            salida.Localidad = entrada.Localidad;
            salida.Calle = entrada.Calle;
            salida.Detalle_direccion = entrada.Detalle_direccion;
            salida.Email = entrada.Email;
            salida.id_condado = entrada.id_condado;
            salida.grupo = entrada.grupo;
            return salida;
        }

        public List<Cliente> toEntity(List<ClienteDto> entradas)
        {
            List<Cliente> salidas = new List<Cliente>();
            foreach (ClienteDto item in entradas)
            {
                salidas.Add(this.toEntity(item));
            }
            return salidas;
        }
        public ClienteDto toDto(Cliente entrada)
        {
            ClienteDto salida = new ClienteDto();
            salida.Documento = entrada.Documento;
            salida.Tipo_documento = entrada.Tipo_documento;
            salida.Telefono = entrada.Telefono;
            salida.Localidad = entrada.Localidad;
            salida.Calle = entrada.Calle;
            salida.Detalle_direccion = entrada.Detalle_direccion;
            salida.Email = entrada.Email;
            salida.id_condado = entrada.id_condado;
            salida.grupo = entrada.grupo;
            return salida;
        }

        public List<ClienteDto> toDto(List<Cliente> entradas)
        {
            List<ClienteDto> salidas = new List<ClienteDto>();
            foreach (Cliente item in entradas)
            {
                salidas.Add(this.toDto(item));
            }
            return salidas;
        }
    }
}
