using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class RegistrarExpedicaoCommand
    {
        public SolicitarColetaCommand coleta { get; set; }

        public DateTime Data { get; set; }  
    }
}
