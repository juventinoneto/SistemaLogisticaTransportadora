using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class RegistrarExpedicaoColetaCommand
    {
        public int IdColeta { get; set; }
        public int IdExpedicao { get; set; }
    }
}
