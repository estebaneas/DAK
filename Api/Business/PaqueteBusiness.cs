using CommonSolution.Dtos;
using DataAccess.Repositories;

namespace Business
{
    public class PaqueteBusiness
    {
        private readonly PaqueteRepository _paqueteRepository;
        public PaqueteBusiness()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public PaqueteDto AltaPaquete(PaqueteDto paquete)
        {
            return this._paqueteRepository.registrarPaquete(paquete);
        }
    }
}
