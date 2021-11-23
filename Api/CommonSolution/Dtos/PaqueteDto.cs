using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class PaqueteDto
    {
        public int id { get; set; }
        public string documentoRemitente { get; set; }
        public string documentoDestinatario { get; set; }
        public int peso { get; set; }
        public int numeroFactura { get; set; }
        public DateTime fechaRecibido{ get; set; }
        public DateTime fechaEnviado { get; set; }
        public DateTime fechaEntregado { get; set; }
        public float distancia { get; set; }
        public int estado { get; set; }
        public int tamaño { get; set; }
    }
}
