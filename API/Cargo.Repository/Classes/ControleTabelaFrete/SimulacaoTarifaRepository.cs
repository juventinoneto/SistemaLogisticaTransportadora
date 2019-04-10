using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleTabelaFrete;

namespace Cargo.Repository.Classes.ControleTabelaFrete
{
    public class SimulacaoTarifaRepository : Repository<SimulacaoTarifa>, ISimulacaoTarifaRepository
    {
        public SimulacaoTarifaRepository(CargoContexto context) : base(context)
        {
        }
    }
}