using System;

namespace CommonSolution.Dtos
{
    public class PaqueteDto
    {
        public int ID { get; set; }
        public double Peso { get; set; }
        public DateTime FechaRecibido { get; set; }
        public DateTime? FechaEnviado { get; set; }
        public DateTime FechaCambioEstado { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string DetalleDireccion { get; set; }
        public int? Distancia { get; set; }
        public int Estado { get; set; }
        public string DocumentoRemitente { get; set; }
        public string DocumentoDestinatario { get; set; }
        public int ID_Zona { get; set; }
        public int ID_Condado { get; set; }
        public int Numero_Factura { get; set; }
        public int Tamano { get; set; }
        public string TrackingNumero { get; set; }
  
    }
}
