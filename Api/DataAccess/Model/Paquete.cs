//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paquete
    {
        public int ID { get; set; }
        public double Peso { get; set; }
        public System.DateTime FechaRecivido { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public System.DateTime FechaCambioEstado { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string DetalleDireccion { get; set; }
        public Nullable<int> Distancia { get; set; }
        public int Estado { get; set; }
        public string DocumentoRemitente { get; set; }
        public string DocumentoDestinatario { get; set; }
        public int ID_Zona { get; set; }
        public int ID_Condado { get; set; }
        public int Numero_Factura { get; set; }
        public int Tamano { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
        public virtual Condado Condado { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Zona Zona { get; set; }
    }
}
