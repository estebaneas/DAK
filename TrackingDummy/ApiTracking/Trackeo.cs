using ApiTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTracking
{
    public class Trackeo
    {
        public string numero { get; set; }
        public double?  latitud { get; set; }
        public double? longitud { get; set; }
        public int estado { get; set; }

        public List<Detail> detalles { get; set; }

        public Trackeo(Tracking trk)

        {
            this.estado = trk.estado;
            this.numero = trk.numero;
            this.latitud = trk.latitud;
            this.longitud = trk.longitud;
        }
    }
}