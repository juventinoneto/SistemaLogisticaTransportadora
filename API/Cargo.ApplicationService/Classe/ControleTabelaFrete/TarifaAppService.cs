using Cargo.ApplicationService.Interfaces.ControleTabelaFrete;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleTabelaFrete;
using System;
using System.Linq;

namespace Cargo.ApplicationService.Classe.ControleTabelaFrete
{
    public class TarifaAppService : AppService<Tarifa>, ITarifaAppService
    {
        private readonly ISimulacaoTarifaAppService _simulacaoAppService;

        private readonly ITarifaRepository _repository;

        public TarifaAppService(
            ITarifaRepository repository,
            ISimulacaoTarifaAppService simulacaoAppService
            ) : base(repository)
        {
            _repository = repository;
            _simulacaoAppService = simulacaoAppService;
        }

        public Tarifa CriarTarifa(Tarifa tarifa)
        {
            var tarifaRegistrada = base.Create(tarifa);
            return tarifaRegistrada;
        }

        public Tarifa RegistrarSimulacao(int idTarifa, SimulacaoTarifa simulacao)
        {
            var tarifa = _repository.GetById(idTarifa);

            tarifa.Simulacoes.ToList().ForEach(s => 
            {
                s.StatusSimulacaoTarifa = StatusSimulacaoTarifa.Status.P;
            });

            simulacao.StatusSimulacaoTarifa = StatusSimulacaoTarifa.Status.C;
            simulacao.Data = new DateTime();

            tarifa.Simulacoes.Add(simulacao);

            return _repository.Update(tarifa);
        }
    }
}