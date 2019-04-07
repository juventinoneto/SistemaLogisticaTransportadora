using Cargo.DomainModel.Models.ControleExpedicao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class ExpedicaoColetaMap : IEntityTypeConfiguration<ExpedicaoColeta>
    {
        public void Configure(EntityTypeBuilder<ExpedicaoColeta> builder)
        {
            builder.HasOne(p => p.Coleta);
            builder.HasOne(p => p.Expedicao);
        }
    }
}
