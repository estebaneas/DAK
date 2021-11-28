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
    public class ClienteRepository
    {
        private ClienteMapper ClienteM;
        private EmpresaMapper EmpresaM;
        private PersonaMapper PersonaM;
        public ClienteRepository()
        {
            this.ClienteM = new ClienteMapper();
            this.EmpresaM = new EmpresaMapper();
            this.PersonaM = new PersonaMapper();
        }
        public void registrarCliente(ClienteDto clienteDto)
        {
            Cliente nuevoCliente = this.ClienteM.toEntity(clienteDto);
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {

                    try
                    {
                        context.Cliente.Add(nuevoCliente);
                        context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                    }
                }
            }
        }

        public bool registrarEmpresa(EmpresaDto empresaDto)
        {
            Empresa nuevaEmpresa = this.EmpresaM.toEntity(empresaDto);
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {

                    try
                    {
                        context.Empresa.Add(nuevaEmpresa);
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
        }

        public bool registrarPersona(PersonaDto personaDto)
        {
            Persona nuevaPersona = this.PersonaM.toEntity(personaDto);
            using (DAKEntities context = new DAKEntities())
            {
                using (DbContextTransaction trans = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {

                    try
                    {
                        context.Persona.Add(nuevaPersona);
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
        }

    }
}
