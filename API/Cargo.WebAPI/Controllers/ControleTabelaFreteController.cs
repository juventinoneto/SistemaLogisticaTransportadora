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

        [HttpPut]
        [Route("simulacao-tarifa")]
        public ActionResult<ResultBase> Post([FromBody] RegistrarTarifaCommand request)
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

        [HttpPut]
        [Route("simulacao-tarifa/{id}")]
        public ActionResult<ResultBase> Put(int idTarifa, [FromBody] RegistrarSimulacaoTarifaCommand request)
        {
            try
            {
                var mapped = _mapper.Map<SimulacaoTarifa>(request);

                var result = _tarifaService.RegistrarSimulacao(idTarifa, mapped);

                return new ResultBase(true, result);
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, request, ex.Message);
            }
        }

        //[HttpGet]
        //[Route("{id}")]
        //public ActionResult<ResultBase> Post([FromBody] SolicitarColetaCommand coleta)
        //{
        //    try
        //    {
        //        var coletaMapped = _mapper.Map<Coleta>(coleta);

        //        var result = _coletaService.RegistrarColeta(coletaMapped);

        //        return new ResultBase(true, coleta);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return new ResultBase(false, coleta, ex.Message);
        //    }
        //}
    }
}