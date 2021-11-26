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
namespace DataAccess.Repositories
{
    public class PaqueteRepository
    {
        private PaqueteMapper PaqueteM;
        public PaqueteRepository()
        {
            this.PaqueteM = new PaqueteMapper();
        }
        public PaqueteDto registrarPaquete(PaqueteDto paquete)
        {
            Paquete nPaquete = this.PaqueteM.toEntity(paquete);
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        context.Paquete.Add(nPaquete);
                        context.SaveChanges();
                        trans.Commit();
                        return this.PaqueteM.toDto(nPaquete);
                    }catch(Exception ex)
                    {
                        trans.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}
