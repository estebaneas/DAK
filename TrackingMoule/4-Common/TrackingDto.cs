using System;
using System.Collections.Generic;

namespace Common
{
    public class TrackingDto
    {
        public string numeroTacking { get; set; }
        public DateTime lastUpdate { get; set; }
        public List<DetalleDto> detalles { get; set; }
    }
}