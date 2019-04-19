using Cargo.DomainModel.Models.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleTabelaFrete
{
    public class RegistrarSimulacaoTarifaCommand
    {
        public int IdSimulacaoTarifa { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public StatusSimulacaoTarifa Status { get; set; }

        public int IdTarifa { get; set; }
    }
}
