using Cargo.DomainModel.Models.ControleTabelaFrete;

namespace Cargo.ApplicationService.Interfaces.ControleTabelaFrete
{
    public interface ITarifaAppService : IAppService<Tarifa>
    {
        Tarifa CriarTarifa(Tarifa tarifa);
        Tarifa RegistrarSimulacao(int idTarifa, SimulacaoTarifa simulacao);
        Tarifa ReajustarTarifa(int idTarifa, SimulacaoTarifa tarifa);
    }
}