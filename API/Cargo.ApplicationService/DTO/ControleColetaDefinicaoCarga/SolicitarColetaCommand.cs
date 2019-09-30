using Cargo.ApplicationService.DTO.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga
{
    public class SolicitarColetaCommand
    {
        public SolicitarColetaClienteCommand Cliente { get; set; }
        public SolicitarColetaParceiroCommand Parceiro { get; set; }
        public DateTime Data { get; set; }
        public EnderecoData Endereco { get; set; }
        public string NomeDestinatario { get; set; }
    }
}
