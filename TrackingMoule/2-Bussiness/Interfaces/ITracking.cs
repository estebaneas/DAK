using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
namespace TrackingMoule.Interfaces
{
    public interface ITracking
    {
        CoordenadasDto getHubicacion();
        List<DetalleDto> getDetalle();
    }
}