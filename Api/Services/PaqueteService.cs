using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingMoule.Bussiness;

namespace Services
{
    public class PaqueteService
    {
        private readonly PaqueteRepository _paqueteRepository;
        private readonly TrackingBusiness _trackingBusiness;
        
        public PaqueteService()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public PaqueteDto AltaPaquete(PaqueteDto paquete)
        {
            string numeroTracking = _trackingBusiness.SolicitarNuevoTracking();
            paquete.TrackingNumero = numeroTracking;
            return this._paqueteRepository.registrarPaquete(paquete);
        }
    }
}
