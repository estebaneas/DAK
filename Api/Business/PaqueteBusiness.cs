using CommonSolution.Dtos;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Linq;

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

        public paquetesInfo getPaquetes(FiltroPaquetes filtro)
        {
            List<PaqueteDto> paquetes = new List<PaqueteDto>();
            paquetesInfo info = new paquetesInfo();
            int totPaquetes = this._paqueteRepository.getTotPaquetes();
            //buscar primer filtro
            if (filtro.tracking != "null")
            {
                paquetes = this._paqueteRepository.getPaquetePortTracking(filtro);
                info.paquetes = paquetes;
                info.totalDePaquetesRegistrados = paquetes.Count();
                return info;
            }
            else if (filtro.documentoRemitente!="null")
            {
                paquetes = this._paqueteRepository.getPaquetePorRemitente(filtro);
                totPaquetes = this._paqueteRepository.getTotPaquetePorRemitente(filtro);
            }
            else if (filtro.documentoDestinatario != "null")
            {
                paquetes = this._paqueteRepository.getPaquetePorDestinatario(filtro);
                totPaquetes = this._paqueteRepository.getTotPaquetePorDestinatario(filtro);
            }
            else if (filtro.fechaRecibido != null)
            {
                paquetes = this._paqueteRepository.getPaquetePorFecha(filtro);
                totPaquetes = this._paqueteRepository.getTotPaquetePorFecha(filtro);
            }
            else if (filtro.estado != null)
            {
                paquetes = this._paqueteRepository.getPaquetePorEstado(filtro);
                totPaquetes = this._paqueteRepository.getTotPaquetePorEstado(filtro);
            }
            else
            {
                paquetes = this._paqueteRepository.getPaquetes(filtro);
                totPaquetes = this._paqueteRepository.getTotPaquetes();
            }

            //filtro
            
            if (filtro.documentoDestinatario != "null")
            {
                int tot = this._paqueteRepository.getTotPaquetePorDestinatario(filtro);
                if (paquetes.Count() > tot) {
                    totPaquetes -= tot;
                }
                paquetes = paquetes.Where(p => p.DocumentoDestinatario == filtro.documentoDestinatario).ToList();
                totPaquetes = paquetes.Count();
            }
            if (filtro.fechaRecibido != null)
            {
                int tot = this._paqueteRepository.getTotPaquetePorFecha(filtro);
                if (paquetes.Count() > tot)
                {
                    totPaquetes -= tot;
                }
                paquetes = paquetes.Where(p => p.FechaRecibido == filtro.fechaRecibido).ToList();
                totPaquetes = paquetes.Count();
            }
            if (filtro.estado != null)
            {
                int tot = this._paqueteRepository.getTotPaquetePorEstado(filtro);
                if (paquetes.Count() > tot)
                {
                    totPaquetes -= tot;
                }
                paquetes = paquetes.Where(p => p.Estado == filtro.estado).ToList();
                totPaquetes = paquetes.Count();
            }
            
            info.paquetes = paquetes;
            info.totalDePaquetesRegistrados = totPaquetes;

            return info;
        }

    }


}
