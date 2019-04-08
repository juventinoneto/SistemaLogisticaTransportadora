using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace Cargo.DomainModel.Models.ControleTabelaFrete
{
    public class Tarifa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarifa { get; set; }

        public int IdColeta { get; set; }

        [ForeignKey("IdColeta")]
        public Coleta Coleta { get; set; }

        public List<SimulacaoTarifa> Simulacoes { get; set; }

        public Tarifa()
        {
            this.Simulacoes = new List<SimulacaoTarifa>();
        }
    }
}
