using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cargo.DomainModel.Models.Commons
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEndereco { get; set; }
        
        public string RuaAvenida { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public int Numero { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Complemento { get; set; }


    }
}