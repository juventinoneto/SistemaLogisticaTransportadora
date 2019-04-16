using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitaColetaClienteController : ControllerBase
    {
        private readonly CargoContexto _context;

        private readonly IMapper _mapper;

        private readonly IColetaAppService _coletaService;
        public SolicitaColetaClienteController
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

        // POST api/values
        [HttpPost]
        [Route("solicita-coleta-cliente")]
        public ActionResult<ResultBase> Post([FromBody] SolicitarColetaCommand coleta)
        {
            try
            {
                var coletaMapped = _mapper.Map<Coleta>(coleta);

                var result = _coletaService.RegistrarColeta(coletaMapped);

                return new ResultBase(true, _mapper.Map<Coleta> (result));
            }
            catch (System.Exception ex)
            {
                return new ResultBase(false, coleta, ex.Message);
            }
        }

    }
}