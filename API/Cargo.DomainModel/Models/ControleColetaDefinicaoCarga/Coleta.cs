using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.Commons;

namespace Cargo.DomainModel.Models.ControleColetaDefinicaoCarga
{
    public class Coleta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColeta { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public int IdParceiro { get; set; }

        [ForeignKey("IdParceiro")]
        public Parceiro Parceiro { get; set; }

        public DateTime Data { get; set; }

        public int IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }


    }
}