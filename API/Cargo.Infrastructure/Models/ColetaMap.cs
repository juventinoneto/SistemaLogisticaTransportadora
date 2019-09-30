using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class ColetaMap : IEntityTypeConfiguration<Coleta>
    {
        public void Configure(EntityTypeBuilder<Coleta> builder)
        {
            builder.ToTable("Coleta");
            builder.HasOne(p => p.Cliente);
            builder.Property(p => p.Data).IsRequired();
            builder.HasOne(p => p.Endereco);
            builder.Property(p => p.NomeDestinatario).HasMaxLength(100);
        }
    }
}