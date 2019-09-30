using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class ExpedicaoCalendarData
    {
        public DateTime Data { get; set; }

        public string Destinatario { get; set; }

        public int DiasRestantes { get; set; }

        public int IdColeta { get; set; }
    }
}
