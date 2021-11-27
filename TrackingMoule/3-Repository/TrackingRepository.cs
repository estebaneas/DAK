using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackingMoule.Models;
using Common;
using System.Data;
using System.Data.Entity;

namespace TrackingMoule.Repository
{
    public class TrackingRepository
    {

        public DateTime getUltimaActualizacion(string NumeroTracking)
        {
            using (DAK_TRACKINGEntities context = new DAK_TRACKINGEntities())
            {
                return context.Tracking.AsNoTracking().FirstOrDefault(t => t.NumeroTracking == NumeroTracking).UlrimaActualizacion;
            }
        }

        public bool registrarTracking(string _NumeroTracking)
        {
            using (DAK_TRACKINGEntities context = new DAK_TRACKINGEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        context.Tracking.Add(new Tracking
                        {
                            NumeroTracking = _NumeroTracking,
                            UlrimaActualizacion = DateTime.Now
                        });
                        context.SaveChanges();
                        trans.Commit();
                        return true;
                    }catch(Exception ex){
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

       /* public bool updateTracking(TrackingDto tracking)
        {
            using (DAK_TRACKINGEntities context = new DAK_TRACKINGEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        context.Tracking.Include("DetalleTracking").FirstOrDefault(d=>d.NumeroTracking==tracking.numeroTacking).DetalleTracking
                        context.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }*/
        public bool Verificar(string NumeroTracking)
        {
            using (DAK_TRACKINGEntities context = new DAK_TRACKINGEntities())
            {
                return context.Tracking.AsNoTracking().Any(p=>p.NumeroTracking==NumeroTracking);
            }
        }
        
        public TrackingDto getTracking(string Numerotracking)
        {
            using (DAK_TRACKINGEntities context = new DAK_TRACKINGEntities())
            {
                Tracking tracking = context.Tracking.AsNoTracking().Include("DetalleTracking").AsNoTracking().FirstOrDefault(t => t.NumeroTracking == Numerotracking);
                return new TrackingDto() {
                    numeroTacking=tracking.NumeroTracking,
                    detalles = tracking.DetalleTracking.Select(d => new DetalleDto {
                        detalle = d.Detalle,
                        Fecha = d.Fecha
                    }).ToList(),
                    lastUpdate = tracking.UlrimaActualizacion
                };
                
            }
        }

    }
}