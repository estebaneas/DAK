using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using TrackingMoule.Interfaces;
using TrackingMoule.Repository;
namespace TrackingMoule.ConcreteClasses
{
    public class TrackingProxy:ITracking
    {
        private string numeroDeTracking;
        private List<DetalleDto> detalles;
        private TrackingOriginal original;
        private DateTime ultimaFechaActu;

        public TrackingProxy(string numeroTracking)
        {
            this.numeroDeTracking = numeroTracking;
            this.original = new TrackingOriginal(numeroTracking);
        }
        public TrackingProxy(TrackingDto tracking) {
            this.numeroDeTracking = tracking.numeroTacking = tracking.numeroTacking;
            this.ultimaFechaActu = tracking.lastUpdate;
            this.original = new TrackingOriginal(tracking.numeroTacking);
            this.detalles = tracking.detalles;
        }
 
        public List<DetalleDto> getDetalle()
        {
            TimeSpan periodo = DateTime.Now - this.ultimaFechaActu;
            if (periodo.TotalMinutes>15)
            {
                return original.getDetalle();
            }
            else
            {
                return this.detalles;
            }
        }
        public CoordenadasDto getHubicacion()
        {
           return this.original.getHubicacion();
        }


   
    }
}