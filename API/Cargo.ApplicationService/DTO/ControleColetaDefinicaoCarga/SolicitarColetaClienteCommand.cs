using Cargo.ApplicationService.DTO.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga
{
    public class SolicitarColetaClienteCommand
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public EnderecoData Endereco { get; set; }
    }
}
