using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.DomainModel.Models.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleTabelaFrete
{
    public class ExpedicaoData
    {
        public int IdExpedicao { get; set; }

        public DateTime Data { get; set; }

        public StatusExpedicao.Status Status { get; set; }

        public List<ExpedicaoColetaData> ExpedicoesColetas { get; set; }
    }
}
