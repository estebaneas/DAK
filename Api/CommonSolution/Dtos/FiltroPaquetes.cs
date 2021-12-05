using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class FiltroPaquetes
    {
        public DateTime? fechaRecibido { get; set; }
        public DateTime? fechaEntregado { get; set; }
        public int? estado { get; set; }
        public string documentoRemitente { get; set; }
        public string documentoDestinatario { get; set; }
        public int? numFactura { get; set; }
        public int? pagina { get; set; }
        public string tracking { get; set; }
        public int paginaActual { get; set; }
        public int paginaTot { get; set; }
        public int paginasPorHoja { get; set; }


    }
}
