using Cargo.DomainModel.Models.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.Property(p => p.RuaAvenida).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Cep).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Uf).HasMaxLength(2).IsRequired();
            builder.Property(p => p.Complemento).HasMaxLength(30);
        }
    }
}