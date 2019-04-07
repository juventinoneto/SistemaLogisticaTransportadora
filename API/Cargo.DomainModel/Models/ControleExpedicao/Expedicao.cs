using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.Commons;

namespace Cargo.DomainModel.Models.ControleExpedicao
{
    public class Expedicao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedicao { get; set; }

        public DateTime Data { get; set; }

        public Status Status { get; set; }

        public List<ExpedicaoColeta> ExpedicoesColetas { get; set; }

        public Expedicao() 
        {
            this.ExpedicoesColetas = new List<ExpedicaoColeta>();
        }
    }
}