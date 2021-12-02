using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Common;
using TrackingMoule.Bussiness;
namespace TrackingMoule.Controllers
{
    public class TrackingController:ApiController
    {
        [HttpGet]
        [ActionName("Rastrear")]
        public CoordenadasDto RastrearPaquete(string NumeroTracking)
        {
            return new TrackingBusiness().Rastrear(NumeroTracking);
        }
        [HttpGet]
        [ActionName("VerificarNumero")]
        public bool verificar(string NumeroTracking)
        {
            return new TrackingBusiness().verificar(NumeroTracking);
        }

        [HttpGet]
        [ActionName("SolicitarNuevoTracking")]
        public string Registrar()
        {
            return new TrackingBusiness().SolicitarNuevoTracking();
        }

        [HttpGet]
        [ActionName("SolicitarDetalle")]
        public List<DetalleDto> getDetalle(string NumeroTracking)
        {
            return new TrackingBusiness().getDetalleTracking(NumeroTracking);
        }

    }
}