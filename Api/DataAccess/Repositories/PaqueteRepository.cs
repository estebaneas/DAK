using CommonSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Mappers;
using System.Data.Entity;
using System.Data;
using CommonSolution;

namespace DataAccess.Repositories
{
    public class PaqueteRepository
    {
        private readonly PaqueteMapper _paqueteMapper;
        public PaqueteRepository()
        {
            this._paqueteMapper = new PaqueteMapper();
        }
        public PaqueteDto registrarPaquete(PaqueteDto paquete)
        {
            Paquete nPaquete = this._paqueteMapper.toEntity(paquete);
            nPaquete.Estado = (int)ESTADO.RECIBIDO;
            nPaquete.FechaRecivido = DateTime.Now;
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        context.Paquete.Add(nPaquete);
                        context.SaveChanges();
                        trans.Commit();
                        return _paqueteMapper.toDto(nPaquete);
                    }
                    catch(Exception ex)
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
