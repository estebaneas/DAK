using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using ApiTracking.Models;
namespace ApiTracking.Controllers
{
    public class TrackingController:ApiController
    {
        /*[HttpGet]
        [ActionName("GetLocation")]
        public Trackeo getLoc(string trkNumber)
        {
            using (TrackingDePaquetesEntities context = new TrackingDePaquetesEntities())
            {
                return new Trackeo(context.Tracking.FirstOrDefault(t=>t.numero==trkNumber));
            }
        }*/

        [HttpGet]
        [ActionName("GetLocation")]
        public coords getLoc(string trkNumber)
        {
            using (TrackingDePaquetesEntities context = new TrackingDePaquetesEntities())
            {
                Trackeo trk =  new Trackeo(context.Tracking.AsNoTracking().FirstOrDefault(t => t.numero == trkNumber));
                return new coords() { lat =trk.latitud, lng = trk.longitud };
            }
        }

        [HttpGet]
        [ActionName("GetDetails")]
        public List<Detail> getDet(string trkNumber)
        {
            using (TrackingDePaquetesEntities context = new TrackingDePaquetesEntities())
            {

                return context.Tracking.Include("Detalle").AsNoTracking().FirstOrDefault(t=>t.numero==trkNumber).Detalle.Select(d=> new Detail {
                    numero=d.numero,
                    numeroTracking = trkNumber,
                    detalle=d.detalle1,
                    Fecha=d.Fecha
                }).ToList();
            }
        }



        [HttpGet]
        [ActionName("NewTracking")]
        public string NewTracking(string client)
        {
            int totalTrackins;
            using (TrackingDePaquetesEntities context = new TrackingDePaquetesEntities())
            {
                totalTrackins = context.Tracking.Count();
            }
            Random rnd = new Random(totalTrackins);
            string trackingNumber = client;
            for (int i = 0; i < 12; i++)
            {
                trackingNumber += rnd.Next(0,9);
            }
            using (TrackingDePaquetesEntities context = new TrackingDePaquetesEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Tracking nTraking = new Tracking();
                        nTraking.numero = trackingNumber;
                        context.Tracking.Add(nTraking);
                        context.Detalle.Add(new Detalle()
                        {
                            TrackingId = nTraking.IDTrack,
                            detalle1 = "Esperando para Embarcar",
                            Fecha = DateTime.Now
                        });
                        context.SaveChanges();
                        trans.Commit();
                        return nTraking.numero;
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        return "";
                    }
                }
                
            }
        }
    }
}