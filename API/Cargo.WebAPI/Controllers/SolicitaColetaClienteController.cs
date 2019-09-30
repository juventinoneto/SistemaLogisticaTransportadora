using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowSpecificOrigin")]
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

        [HttpGet]
        public ActionResult<IEnumerable<ExpedicaoCalendarData>> Get()
        {
            var result = _coletaService.ListarColetasExpedicoes().ToList();
            return result;
        }

    }
}