using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Infrastructure.Model;
using Cargo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Cargo.Infrastructure
{
    public class CargoContexto : DbContext
    {
        DbSet<Usuario> Usuario { get; set; }

        DbSet<Endereco> Endereco { get; set; }

        DbSet<Parceiro> Parceiro { get; set; }        

        DbSet<Cliente> Cliente { get; set; }

        DbSet<Coleta> Coleta { get; set; }

        DbSet<Expedicao> Expedicao { get; set; }

        DbSet<ExpedicaoColeta> ExpedicaoColeta { get; set; }

        DbSet<Tarifa> Tarifa { get; set; }

        DbSet<SimulacaoTarifa> SimulacaoTarifa { get; set; }

        public CargoContexto(DbContextOptions<CargoContexto> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());

            modelBuilder.ApplyConfiguration(new ParceiroMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ColetaMap());

            modelBuilder.ApplyConfiguration(new ExpedicaoMap());
            modelBuilder.ApplyConfiguration(new ExpedicaoColetaMap());

            modelBuilder.ApplyConfiguration(new TarifaMap());
            modelBuilder.ApplyConfiguration(new SimulacaoTarifaMap());
        }
    }
}
