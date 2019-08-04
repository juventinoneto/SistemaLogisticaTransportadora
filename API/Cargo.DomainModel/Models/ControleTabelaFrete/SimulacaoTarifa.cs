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

        public int IdTarifa { get; set; }

        [ForeignKey("IdTarifa")]
        public Tarifa Tarifa { get; set; }

        public SimulacaoTarifa RedefinirTarifa(SimulacaoTarifa simulacao) 
        {
            this.Data = simulacao.Data;
            this.Valor = simulacao.Valor;
            
            return this;
        }

        // public SimulacaoTarifa DefinirValor(string origem, string destino)
        // {


        //     return this;
        // }
    }
}