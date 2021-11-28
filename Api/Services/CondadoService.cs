using CommonSolution.Dtos;
using DataAccess.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CondadoService
    {
        private readonly CondadoRepository _condadoRepository;
        public CondadoService()
        {
            this._condadoRepository = new CondadoRepository();
        }
        public List<CondadoDto> ListaCondado()
        {
            return this._condadoRepository.ListaCondado();
        }
    }
}
