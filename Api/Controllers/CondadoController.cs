using Services;
using System.Web.Http;

namespace Api.Controllers
{
    public class CondadoController : ApiController
    {
        private readonly CondadoService _condadoService;
        public CondadoController()
        {
            this._condadoService = new CondadoService();
        }
        /// <summary>
        /// Trae la lista de Condados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult ListaCondado()
        {
            var result = this._condadoService.ListaCondado();
            return Ok(result);
        }
    }
}
