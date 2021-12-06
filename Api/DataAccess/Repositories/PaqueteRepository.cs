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

        public List<PaqueteDto> getPaquetes(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(p=>p.ID).Skip(filtro.paginasPorHoja * (filtro.paginaActual - 1)).Take(filtro.paginasPorHoja).ToList());
            }
        }
        public int getTotPaquetes()
        {
            using (DAKEntities context = new DAKEntities())
            {
                return context.Paquete.AsNoTracking().Count();
            }
        }


        public List<PaqueteDto> getPaquetePortTracking(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(P=>P.ID).Where(p=>p.TrackingNumero==filtro.tracking).Skip(filtro.paginasPorHoja * (filtro.paginaActual-1)).Take(filtro.paginasPorHoja).ToList());
            }
        }

        public List<PaqueteDto> getPaquetePorFecha(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return  this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(p=>p.ID).Where(p => p.FechaRecivido == filtro.fechaRecibido).Skip(filtro.paginasPorHoja * (filtro.paginaActual - 1)).Take(filtro.paginasPorHoja).ToList());
            }
        }

        public int getTotPaquetePorFecha(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return context.Paquete.AsNoTracking().Where(p => p.FechaRecivido == filtro.fechaRecibido).Count();
            }
        }

        public List<PaqueteDto> getPaquetePorDestinatario(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(p=>p.ID).Where(p => p.DocumentoDestinatario == filtro.documentoDestinatario).Skip(filtro.paginasPorHoja * (filtro.paginaActual - 1)).Take(filtro.paginasPorHoja).ToList());
            }
        }
        public int getTotPaquetePorDestinatario(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return context.Paquete.AsNoTracking().Where(p => p.DocumentoDestinatario == filtro.documentoDestinatario).Count();

            }
        }
        public List<PaqueteDto> getPaquetePorRemitente(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(p => p.ID).Where(p => p.DocumentoRemitente == filtro.documentoRemitente).Skip(filtro.paginasPorHoja * (filtro.paginaActual - 1)).Take(filtro.paginasPorHoja).ToList());
            }
        }

        public int getTotPaquetePorRemitente(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return context.Paquete.AsNoTracking().Where(p => p.DocumentoRemitente == filtro.documentoRemitente).Count();
            }
        }

        public List<PaqueteDto> getPaquetePorEstado(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return this._paqueteMapper.toDto(context.Paquete.AsNoTracking().OrderByDescending(p=>p.ID).Where(p => p.Estado == filtro.estado).Skip(filtro.paginasPorHoja * (filtro.paginaActual - 1)).Take(filtro.paginasPorHoja).ToList());
            }
        }

        public int getTotPaquetePorEstado(FiltroPaquetes filtro)
        {
            using (DAKEntities context = new DAKEntities())
            {
                return context.Paquete.AsNoTracking().Where(p => p.Estado == filtro.estado).Count();
            }
        }





    }
}
