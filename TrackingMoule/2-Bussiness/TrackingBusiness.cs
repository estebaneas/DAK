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
        TrackingRepository TrackingR;
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
            TrackingProxy proxy = new TrackingProxy(new TrackingRepository().getTracking(numeroTracking));
            return proxy.getDetalle();
        }

        public TrackingDto getTracking(string numeroTracking)
        {
            return new TrackingRepository().getTracking(numeroTracking);
        }

        public bool verificar(string numeroTracking)
        {
            return new TrackingRepository().Verificar(numeroTracking);
        }

        public string SolicitarNuevoTracking()
        {
            string url = "https://localhost:44301/api/Tracking/NewTracking?client=" + "DAK";
            WebRequest request = WebRequest.Create(url);
            /*string data = "DAK";
            request.Method = "POST";
            request.ContentLength = data.Length;
            //request.ContentType= "application/json";
            request.ContentType = "text/plain";*/
            string nroTracking;

            /*using (var StreamW = new StreamWriter(request.GetRequestStream()))
            {
                StreamW.Write(data);
                StreamW.Flush();
                StreamW.Close();
                var respuesta = (HttpWebResponse)request.GetResponse();
                using (var streamR = new StreamReader(respuesta.GetResponseStream()))
                {
                    string resultado = streamR.ReadToEnd();
                }
            }*/


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