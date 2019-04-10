using Microsoft.AspNetCore.Mvc;

namespace Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitaColetaEmpresaParceiraController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        
    }
}