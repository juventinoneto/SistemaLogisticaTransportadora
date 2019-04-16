using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly IColetaAppService _coletaService;

        public TestController(
            CargoContexto context,
            IMapper mapper,
            IColetaAppService coletaService
            )
        {
            _context = context;
            _mapper = mapper;
            _coletaService = coletaService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] SolicitarColetaCommand coleta)
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

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
