using CommonSolution.Dtos;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    public class CondadoMapper
    {
        public CondadoDto ToDto(Condado entrada)
        {
            CondadoDto salida = new CondadoDto();
            salida.ID = entrada.ID;
            salida.Nombre = entrada.Nombre;
            return salida;
        }


        public List<CondadoDto> toEntity(List<Condado> entradas)
        {
            List<CondadoDto> salidas = new List<CondadoDto>();
            foreach (Condado item in entradas)
            {
                salidas.Add(this.ToDto(item));
            }
            return salidas;
        }
    }
}
