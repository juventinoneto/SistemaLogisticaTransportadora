using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleTabelaFrete;

namespace Cargo.ApplicationService.Classe.ControleTabelaFrete
{
    public class SimulacaoTarifaAppService : AppService<SimulacaoTarifa>, ISimulacaoTarifaAppService
    {
        public SimulacaoTarifaAppService(ISimulacaoTarifaRepository repository) : base(repository)
        {
        }
    }
}