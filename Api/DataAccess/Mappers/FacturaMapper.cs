using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSolution.Dtos;
using DataAccess.Model;
namespace DataAccess.Mappers
{
    public class FacturaMapper
    {
        public Factura toEntity(FacturaDto entrada)
        {
            Factura salida = new Factura();
            salida.FechaDepago = entrada.FechaDepago;
            salida.Monto = entrada.Monto;
            salida.MontoFinal = entrada.MontoFinal;
            salida.Numero = entrada.Numero;
            return salida;
        }


        public List<Factura> toEntity(List<FacturaDto>entradas)
        {
            List<Factura> salidas = new List<Factura>();
            foreach (FacturaDto item in entradas)
            {
                salidas.Add(this.toEntity(item));
            }
            return salidas;
        }



        public FacturaDto ToDto(Factura entrada)
        {
            FacturaDto salida = new FacturaDto();
            salida.FechaDepago = entrada.FechaDepago;
            salida.Monto = entrada.Monto;
            salida.MontoFinal = entrada.MontoFinal;
            salida.Numero = entrada.Numero;
            return salida;
        }


        public List<FacturaDto> toEntity(List<Factura> entradas)
        {
            List<FacturaDto> salidas = new List<FacturaDto>();
            foreach (Factura item in entradas)
            {
                salidas.Add(this.ToDto(item));
            }
            return salidas;
        }
    }
}
