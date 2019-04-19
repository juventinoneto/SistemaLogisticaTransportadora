using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControleExpedicaoController : ControllerBase
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly IClienteAppService _clienteService;

        private readonly IExpedicaoAppService _expedicaoService;

        private readonly IExpedicaoColetaAppService _expedicaoColetaAppService;

        public ControleExpedicaoController(
            CargoContexto context,
            IMapper mapper,
            IClienteAppService clienteService,
            IExpedicaoAppService expedicaoService)
        {
            _context = context;
            _mapper = mapper;
            _clienteService = clienteService;
            _expedicaoService = expedicaoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return null;

        }

        [HttpGet]
        [Route("marcacao-coleta-data-atual")]
        public ActionResult<List<ColetaData>> GetColetasDataAtual()
        {
            var retorno = _expedicaoService.GetExpedicoesDiarias().ToList();

            return _mapper.Map<List<Coleta>, List<ColetaData>>(retorno);

        }

        [HttpPost]
        [Route("agendamento-expedicao")]
        public ActionResult<ResultBase> PostAgendamentoExpedicao([FromBody] IEnumerable<RegistrarExpedicaoColetaCommand> request)
        {
            try
            {
                var mapped = _mapper.Map<List<RegistrarExpedicaoColetaCommand>, List<ExpedicaoColeta>>(request.ToList());

                var result = _expedicaoColetaAppService.RegistrarExpedicao(mapped);

                return new ResultBase(true, result);
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, request, ex.Message);
            }
        }
    }
}