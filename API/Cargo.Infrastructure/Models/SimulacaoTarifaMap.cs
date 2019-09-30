using System;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cargo.Infrastructure.Models
{
    public class SimulacaoTarifaMap : IEntityTypeConfiguration<SimulacaoTarifa>
    {
        public void Configure(EntityTypeBuilder<SimulacaoTarifa> builder)
        {
            builder.HasOne(p => p.Tarifa);
            builder.Property(p => p.Data).IsRequired();
            builder.Property(p => p.Valor).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.StatusSimulacaoTarifa).IsRequired();
            builder.Property(p => p.StatusSimulacaoTarifa)
                .HasConversion(
                    v => v.ToString(),
                    v => (StatusSimulacaoTarifa.Status)Enum.Parse(typeof(StatusSimulacaoTarifa.Status), v));
        }
    }
}