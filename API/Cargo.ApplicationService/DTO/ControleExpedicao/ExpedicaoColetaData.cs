using Cargo.ApplicationService.DTO.ControleTabelaFrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class ExpedicaoColetaData
    {
        public int IdExpedicaoColeta { get; set; }

        public int IdColeta { get; set; }
        public ColetaData Coleta { get; set; }

        public int IdExpedicao { get; set; }

        public ExpedicaoData Expedicao { get; set; }
    }
}
