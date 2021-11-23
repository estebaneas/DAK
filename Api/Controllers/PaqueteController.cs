using CommonSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Api.Controllers
{
    public class PaqueteController : ApiController
    {
        // GET: Paquete
  
        [HttpGet]
        [ActionName("Test")]
        public string facutraTest()
        {
            return "PaqueteControllerFunciona";
        }


        [HttpPost]
        [ActionName("Test")]
        public bool ProcesarPaquete([FromBody]object paquete)
        {
            return true;
        }

    }
}