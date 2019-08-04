using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace Cargo.DomainModel.Models.ControleExpedicao
{
    public class Expedicao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedicao { get; set; }

        public DateTime Data { get; set; }

        public StatusExpedicao.Status Status { get; set; }

        public List<Coleta> Coletas { get; set; }

        public Expedicao() 
        {
            this.Coletas = new List<Coleta>();
        }
    }
}