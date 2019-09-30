using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cargo.ApplicationService.Classe.ControleTabelaFrete;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleTabelaFrete;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleTabelaFrete;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControleTabelaFreteController : ControllerBase
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly ITarifaAppService _tarifaService;

        public ControleTabelaFreteController(
            CargoContexto context,
            IMapper mapper,
            ITarifaAppService tarifaService)
        {
            _context = context;
            _mapper = mapper;
            _tarifaService = tarifaService;
        }

        [HttpPost]
        public ActionResult<ResultBase> PostDefinirTarifa([FromBody] RegistrarTarifaCommand request)
        {
            try
            {
                var mapped = _mapper.Map<Tarifa>(request);

                var result = _tarifaService.CriarTarifa(mapped);

                return new ResultBase(true, _mapper.Map<TarifaData>(result));
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, request, ex.Message);
            }
        }

        //[HttpPut]
        //public ActionResult<ResultBase> Put(int idTarifa, [FromBody] RegistrarSimulacaoTarifaCommand request)
        //{
        //    try
        //    {
        //        var mapped = _mapper.Map<SimulacaoTarifa>(request);

        //        var result = _tarifaService.RegistrarSimulacao(idTarifa, mapped);

        //        return new ResultBase(true, result);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return new ResultBase(false, request, ex.Message);
        //    }
        //}        
    }
}