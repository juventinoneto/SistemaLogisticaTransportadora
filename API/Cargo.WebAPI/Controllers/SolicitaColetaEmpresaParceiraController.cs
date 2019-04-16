using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitaColetaEmpresaParceiraController : ControllerBase
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly IColetaAppService _coletaService;

        public SolicitaColetaEmpresaParceiraController
            (
            CargoContexto context,
            IMapper mapper,
            IColetaAppService coletaService
            ) 
        {
            _context = context;
            _mapper = mapper;
            _coletaService = coletaService;
        }

        [HttpPost]
        [Route("solicita-coleta-empresa-parceira")]
        public ActionResult<ResultBase> Post([FromBody] SolicitarColetaCommand coleta)
        {
            try
            {
                var coletaMapped = _mapper.Map<Coleta>(coleta);

                var result = _coletaService.RegistrarColeta(coletaMapped);

                return new ResultBase(true, result);
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, coleta, ex.Message);
            }
        }
        
    }
}