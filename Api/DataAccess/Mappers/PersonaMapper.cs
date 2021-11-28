using CommonSolution.Dtos;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    public class PersonaMapper
    {
        public Persona toEntity(PersonaDto entrada)
        {
            Persona salida = new Persona();
            salida.Nombre = entrada.Nombre;
            salida.Apellido = entrada.Apellido;
            salida.Documento = entrada.Documento;
            return salida;
        }

        public PersonaDto toDto(Persona entrada)
        {
            PersonaDto salida = new PersonaDto();
            salida.Nombre = entrada.Nombre;
            salida.Apellido = entrada.Apellido;
            salida.Documento = entrada.Documento;
            return salida;
        }
    }
}
