using CommonSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using System.Data;
using System.Data.Entity;
using DataAccess.Mappers;

namespace DataAccess.Repositories
{
    public class FacturaRepository
    {
        private FacturaMapper FacturaM;
        public FacturaRepository ()
        {
            this.FacturaM = new FacturaMapper();
        }
        public FacturaDto registrarFacutra(FacturaDto factura)
        {
            Factura nFactura = this.FacturaM.toEntity(factura);
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                   
                    try
                    {
                        context.Factura.Add(nFactura);
                        context.SaveChanges();
                        trans.Commit();
                        return this.FacturaM.ToDto(nFactura);
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}
