using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class ParceiroMap : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("Parceiro");
            builder.Property(p => p.Nome).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Documento).HasMaxLength(15).IsRequired();
            builder.HasOne(p => p.Endereco);
        }
    }
}