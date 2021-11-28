using CommonSolution;
using CommonSolution.Dtos;
using DataAccess.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PaqueteBusiness
    {
        private readonly PaqueteRepository _paqueteRepository;
        public PaqueteBusiness ()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public PaqueteDto AltaPaquete(PaqueteDto paquete)
        {
            return this._paqueteRepository.registrarPaquete(paquete);
        }

    }
}
