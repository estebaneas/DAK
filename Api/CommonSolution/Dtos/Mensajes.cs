using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class Mensaje
    {
        public string descripcion { get; set; }
        public int? numero { get; set; }
        public bool boolean { get; set; }
        public string mensaje { get; set; }

        public List<string> colErrores { get; set; }
    }
}
