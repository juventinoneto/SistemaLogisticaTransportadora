using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleTabelaFrete;

namespace Cargo.ApplicationService.Classe.ControleTabelaFrete
{
    public class SimulacaoTarifaAppService : AppService<SimulacaoTarifa>, ISimulacaoTarifaAppService
    {
        private readonly ISimulacaoTarifaRepository _repository;

        public SimulacaoTarifaAppService(ISimulacaoTarifaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public SimulacaoTarifa RedefinirSimulacao(SimulacaoTarifa simulacaoTarifa)
        {
            _repository.Update(simulacaoTarifa);
            return simulacaoTarifa;
        }
    }
}