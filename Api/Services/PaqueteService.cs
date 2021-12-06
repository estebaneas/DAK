using CommonSolution.Dtos;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PaqueteService
    {
        private readonly PaqueteRepository _paqueteRepository;
        public PaqueteService()
        {
            this._paqueteRepository = new PaqueteRepository();
        }
        public async Task<PaqueteDto> AltaPaquete(PaqueteDto paquete)
        {
            string trackingNumero = "";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44361/api/Tracking/");
                //client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                try
                {
                    HttpResponseMessage response = client.GetAsync("SolicitarNuevoTracking").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        trackingNumero = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }
                }
                catch (Exception ex)
                {
                    return null;
                    throw;
                }
            }
            paquete.TrackingNumero = trackingNumero;
            paquete.ID_Zona = 1;
            return this._paqueteRepository.registrarPaquete(paquete);
        }
    }
}
