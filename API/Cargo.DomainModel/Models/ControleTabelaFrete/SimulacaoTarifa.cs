using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.Commons;

namespace Cargo.DomainModel.Models.ControleTabelaFrete
{
    public class SimulacaoTarifa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSimulacaoTarifa { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public StatusSimulacaoTarifa.Status StatusSimulacaoTarifa { get; set; }

        public int IdSimulacao { get; set; }

        [ForeignKey("IdSimulacao")]
        public Tarifa Tarifa { get; set; }
    }
}