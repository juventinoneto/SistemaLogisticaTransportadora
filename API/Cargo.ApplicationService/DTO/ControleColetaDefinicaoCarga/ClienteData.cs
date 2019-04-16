using Cargo.ApplicationService.DTO.Commons;

namespace Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga
{
    public class ClienteData
    {
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public int IdEndereco { get; set; }
        public EnderecoData Endereco { get; set; }
    }
}