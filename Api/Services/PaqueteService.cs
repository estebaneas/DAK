using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PaqueteService
    {
        private readonly PaqueteRepository _paqueteRepository;
        public PaqueteService()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public PaqueteDto AltaPaquete(PaqueteDto paquete)
        {
            return this._paqueteRepository.registrarPaquete(paquete);
        }
    }
}
