using CommonSolution;
using CommonSolution.Dtos;
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
        private PaqueteRepository _paqueteRepository;
        public PaqueteBusiness ()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public PaqueteDto AltaPaquete(PaqueteDto paquete)
        {
            paquete.FechaRecivido = DateTime.Now;
            paquete.Estado = (int)ESTADO.RECIBIDO;
            return this._paqueteRepository.registrarPaquete(paquete);
        }

    }
}
