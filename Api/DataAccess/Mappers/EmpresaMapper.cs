using CommonSolution.Dtos;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    public class EmpresaMapper
    {
        public Empresa toEntity(EmpresaDto entrada)
        {
            Empresa salida = new Empresa();
            salida.Rut = entrada.Rut;
            salida.Razon_social = entrada.Razon_social;
            return salida;
        }

        public EmpresaDto toDto(Empresa entrada)
        {
            EmpresaDto salida = new EmpresaDto();
            salida.Rut = entrada.Rut;
            salida.Razon_social = entrada.Razon_social; 
            return salida;
        }
    }
}
