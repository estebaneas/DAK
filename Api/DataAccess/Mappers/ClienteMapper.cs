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
            return salida;
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
            return salida;
        }
    }
}
