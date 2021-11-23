using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSolution.Dtos;
namespace Business.Interfaces
{
    public interface IPago
    {
        bool procesarPago(FacturaDto factura);
    }
}
