using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleTabelaFrete
{
    public class RegistrarTarifaCommand
    {
        public int? IdTarifa { get; set; }
        public int IdColeta { get; set; }
        public List<RegistrarSimulacaoTarifaCommand> Simulacoes { get; set; }
    }
}
