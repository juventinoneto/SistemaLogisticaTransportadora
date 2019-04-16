using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly IClienteAppService _clienteService;

        private readonly IColetaAppService _coletaService;

        public ValuesController(
            CargoContexto context,
            IMapper mapper,
            IClienteAppService clienteService,
            IColetaAppService coletaService
            ) 
        {
            _context = context;
            _mapper = mapper;
            _clienteService = clienteService;
            _coletaService = coletaService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _clienteService.GetAll().ToList();
            return Ok(_mapper.Map<List<Cliente>, List<ClienteData>>(result));

        }
 
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("api/[controller]/solicita-coleta")]
        public void Post([FromBody] SolicitarColetaCommand coleta)
        {
            Console.Write(coleta);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost]
        [Route("")]
        public void PostSolicitarColeta([FromBody] SolicitarColetaCommand coleta)
        {
            try
            {
                //var coletaMapped = _mapper.Map<Coleta>(coleta);

                //var result = _coletaService.RegistrarColeta(coletaMapped);

                //return new ResultBase(true, result);

                //return new ResultBase(false, null);
                Console.Write(coleta);
            }
            catch (System.Exception)
            {
                //return new ResultBase(false, coleta);
            }
        }
    }
}
