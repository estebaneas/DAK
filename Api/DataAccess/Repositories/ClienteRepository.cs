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
        private readonly ClienteMapper ClienteM;
        private readonly EmpresaMapper EmpresaM;
        private readonly PersonaMapper PersonaM;
        public ClienteRepository()
        {
            this.ClienteM = new ClienteMapper();
            this.EmpresaM = new EmpresaMapper();
            this.PersonaM = new PersonaMapper();
        }
        public bool registrarCliente(ClienteDto clienteDto)
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
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        Console.WriteLine(ex);
                        return false;
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

        public List<ClienteDto> buscarClientes(string busqueda)
        {
            List<Cliente> resultadoBusqueda = new List<Cliente>();
            List<ClienteDto> resultadoBusquedaDto = new List<ClienteDto>();

            using (DAKEntities context = new DAKEntities())
            {
                    try
                    {
                        resultadoBusqueda = context.Cliente.AsNoTracking().Where(c => c.Documento.Contains(busqueda)).ToList();
                        resultadoBusquedaDto = ClienteM.toDto(resultadoBusqueda); 
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                        return null;
                    }
            }

            return resultadoBusquedaDto;
        }

        public List<ClienteDto> listaClientes()
        {
            List<Cliente> resultadoBusqueda = new List<Cliente>();
            List<ClienteDto> resultadoBusquedaDto = new List<ClienteDto>();

            using (DAKEntities context = new DAKEntities())
            {
                try
                {
                    resultadoBusqueda = context.Cliente.AsNoTracking().ToList();
                    resultadoBusquedaDto = ClienteM.toDto(resultadoBusqueda);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    return null;
                }
            }

            return resultadoBusquedaDto;
        }

    }
}
