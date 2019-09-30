using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.DTO.ControleTabelaFrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo.ApplicationService.DTO.ControleExpedicao
{
    public class ColetaData
    {
        public int IdColeta { get; set; }

        public int IdCliente { get; set; }

        public ClienteData Cliente { get; set; }

        public int IdParceiro { get; set; }

        public ParceiroData Parceiro { get; set; }

        public DateTime Data { get; set; }

        public int IdEndereco { get; set; }

        public EnderecoData Endereco { get; set; }

        public List<TarifaData> Tarifas { get; set; }

        public string NomeDestinatario { get; set; }
    }
}
