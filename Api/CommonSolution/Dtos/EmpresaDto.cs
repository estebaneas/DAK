using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class EmpresaDto
    {
        public string Razon_social { get; set; }
        public string Rut { get; set; }

        public virtual ClienteDto Cliente { get; set; }
    }
}
