using CommonSolution.Dtos;
using DataAccess.Mappers;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CondadoRepository
    {
        private readonly CondadoMapper _condadoMapper;
        public CondadoRepository()
        {
            this._condadoMapper = new CondadoMapper();
        }
        public List<CondadoDto> ListaCondado()
        {
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var result = context.Condado.OrderBy(o => o.Nombre).ToList();
                        return _condadoMapper.toEntity(result);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        Console.Write(ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
