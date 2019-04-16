using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe.ControleTabelaFrete
{
    public class SimulacaoTarifaAppService : AppService<SimulacaoTarifa>, ISimulacaoTarifaAppService
    {
        public SimulacaoTarifaAppService(IRepository<SimulacaoTarifa> repository) : base(repository)
        {
        }
    }
}