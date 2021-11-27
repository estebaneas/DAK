using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using TrackingMoule.Interfaces;

namespace TrackingMoule.ConcreteClasses
{
    public class TrackingOriginal:ITracking
    {
        private string NumeroTracking;

        public TrackingOriginal(string numeroTracking)
        {
            this.NumeroTracking = numeroTracking;
        }

        public List<DetalleDto> getDetalle()
        {
            string url = "https://localhost:44301/api/Tracking/GetDetails?trkNumber=" + this.NumeroTracking;
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse respuesta = (HttpWebResponse)request.GetResponse();
            string detalles;
            using (Stream stream = respuesta.GetResponseStream())
            {
                StreamReader sReader = new StreamReader(stream);
                detalles = sReader.ReadToEnd().Trim('\\', '\"');
                sReader.Close();
            }
            List<DetalleDto> colDetalles = new List<DetalleDto>();
            colDetalles = new JavaScriptSerializer().Deserialize<List<DetalleDto>>(detalles);
            return colDetalles;
        }
        /*Trim('\\', '\"')*/
        public  CoordenadasDto getHubicacion()
        {
            string url = "https://localhost:44301/api/Tracking/GetLocation?trkNumber=" + this.NumeroTracking;
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse respuesta = (HttpWebResponse)request.GetResponse();
            string hubi;
            using (Stream stream = respuesta.GetResponseStream())
            {
                StreamReader streamR = new StreamReader(stream);
                hubi = streamR.ReadToEnd().Trim('\\', '\"');
                streamR.Close();
            }
            CoordenadasDto coords = new JavaScriptSerializer().Deserialize<CoordenadasDto>(hubi);
            return  coords;
        }

    }
}