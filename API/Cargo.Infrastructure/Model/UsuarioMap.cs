using System.ComponentModel.DataAnnotations.Schema;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(p => p.Nome).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Documento).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Telefone).HasMaxLength(15).IsRequired();
        }
    }
}