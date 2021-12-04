using ApiTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTracking
{
    public class Detail
    {

   
        public int numero { get; set; }
        public string numeroTracking { get; set; }
        public DateTime? Fecha { get; set; }
        public string detalle { get; set; }
       /* public Detail(Detalle det)
        {
            this.numero = det.numero;
            this.numeroTracking = det.numeroTracking;
            this.Fecha = det.Fecha;
            this.detalle = det.detalle1;
        }*/

    }
}