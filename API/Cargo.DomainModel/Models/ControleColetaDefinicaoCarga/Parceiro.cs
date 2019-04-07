using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.Commons;

namespace Cargo.DomainModel.Models.ControleColetaDefinicaoCarga
{
    public class Parceiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdParceiro { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public int IdEndereco { get; set; }
        
        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }  
    }
}