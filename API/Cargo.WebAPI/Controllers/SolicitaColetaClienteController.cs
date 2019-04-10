using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitaColetaClienteController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void Post()
        {
        }
    }
}