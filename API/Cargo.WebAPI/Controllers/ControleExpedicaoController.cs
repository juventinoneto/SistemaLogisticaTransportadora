using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
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

        [HttpPost]
        public ActionResult<ResultBase> PostAgendamentoExpedicao([FromBody] RegistrarExpedicaoCommand request)
        {
            try
            {
                var coleta = _mapper.Map<Coleta>(request.coleta);

                var expedicao = _expedicaoService.DefinirExpedicao(request, coleta);

                return new ResultBase(true, _mapper.Map<Expedicao>(expedicao));
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, request, ex.Message);
            }
        }
    }
}