using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    public class DetalleDto
    {
        public int numero { get; set; }
        public string numeroTracking { get; set; }
        public DateTime? Fecha { get; set; }
        public string detalle { get; set; }
    }
}