using System;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleExpedicao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Model
{
    public class ExpedicaoMap : IEntityTypeConfiguration<Expedicao>
    {
        public void Configure(EntityTypeBuilder<Expedicao> builder)
        {
            builder.Property(p => p.Data).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (StatusExpedicao.Status)Enum.Parse(typeof(StatusExpedicao.Status), v));
        }
    }
}