using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
   public class paquetesInfo
    {
        public List<PaqueteDto> paquetes { get; set; }
        public int totalDePaquetesRegistrados { get; set; }
    }
}
