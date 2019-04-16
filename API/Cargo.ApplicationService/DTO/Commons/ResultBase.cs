using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.Commons
{
    public class ResultBase
    {
        public bool Sucesso { get; set; }
        public Object Object { get; set; }

        public string Mensagem { get; set; }

        public ResultBase(bool sucesso, Object obj, string mensagem = "")
        {
            this.Sucesso = sucesso;
            this.Object = obj;
            this.Mensagem = mensagem;
        }
    }
}
