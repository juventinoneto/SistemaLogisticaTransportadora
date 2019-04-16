using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
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

        private readonly IClienteAppService _clienteService;
        public ControleTabelaFreteController(
            CargoContexto context,
            IMapper mapper,
            IClienteAppService clienteService)
        {
            _context = context;
            _mapper = mapper;
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return null;

        }
    }
}