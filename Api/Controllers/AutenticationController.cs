using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    public class AutenticationController : ApiController
    {
        [HttpGet]
        [ActionName("Test")]
        public string facutraTest()
        {
            return "AutenticationFuncionando";
        }
        // GET: Autentication

    }
}