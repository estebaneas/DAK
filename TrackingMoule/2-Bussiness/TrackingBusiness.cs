using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Common;
using TrackingMoule.ConcreteClasses;
using TrackingMoule.Repository;
namespace TrackingMoule.Bussiness
{
    public class TrackingBusiness
    {
        private TrackingRepository TrackingR;
        private string URL = "https://localhost:44301/api/Tracking/NewTracking?client=DAK";
        public TrackingBusiness()
        {
            this.TrackingR = new TrackingRepository();
        }
        /*public List<DetalleDto> getDetalles(string numeroTracking)
        {
            return new TrackingRepository().getDetalle(numeroTracking);
        }*/
        /*public DateTime getUltimaFechaDeActualizacion(string numeroTracking)
        {
            return new TrackingRepository().getUltimaActualizacion(numeroTracking);
        }
        */
        public CoordenadasDto Rastrear(string numeroTracking)
        {
            return new TrackingProxy(numeroTracking).getHubicacion();
        }
        public List<DetalleDto> getDetalleTracking(string numeroTracking)
        {
            TrackingProxy proxy = new TrackingProxy(TrackingR.getTracking(numeroTracking));
            return proxy.getDetalle();
        }

        public TrackingDto getTracking(string numeroTracking)
        {
            return TrackingR.getTracking(numeroTracking);
        }

        public bool verificar(string numeroTracking)
        {
            return TrackingR.Verificar(numeroTracking);
        }

        public string SolicitarNuevoTracking()
        {

            WebRequest request = WebRequest.Create(URL);
            string nroTracking;

            HttpWebResponse respusta = (HttpWebResponse)request.GetResponse();
            using (Stream stream = respusta.GetResponseStream())
            {
                StreamReader streamR = new StreamReader(stream);
                nroTracking = streamR.ReadToEnd().Trim('\\','\"');
            }
            TrackingR.registrarTracking(nroTracking);
            return nroTracking;
        }
    }
}