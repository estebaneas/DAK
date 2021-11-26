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
        private PaqueteRepository PaqueteRep;
        public PaqueteBusiness ()
        {
            this.PaqueteRep = new PaqueteRepository();
        }
        public PaqueteDto  registrarPaquete(PaqueteDto paquete)
        {
            paquete.FechaRecivido = DateTime.Now;
            paquete.Estado = (int)ESTADO.RECIBIDO;
            return this.PaqueteRep.registrarPaquete(paquete);
        }

    }
}
