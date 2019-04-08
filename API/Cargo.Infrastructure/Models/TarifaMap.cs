using Cargo.DomainModel.Models.ControleTabelaFrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Models
{
    public class TarifaMap : IEntityTypeConfiguration<Tarifa>
    {
        public void Configure(EntityTypeBuilder<Tarifa> builder)
        {
            builder.HasOne(p => p.Coleta);
        }
    }
}