using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace Cargo.DomainModel.Models.ControleExpedicao
{
    public class ExpedicaoColeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedicaoColeta { get; set; }

        public int IdColeta { get; set; }

        [ForeignKey("IdColeta")]
        public Coleta Coleta { get; set; }

        public int IdExpedicao { get; set; }

        [ForeignKey("IdExpedicao")]
        public Expedicao Expedicao { get; set; }
    }
}