using Cargo.ApplicationService.Interfaces.ControleTabelaFrete;
using Cargo.ApplicationService.Util;
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

        public Tarifa ReajustarTarifa(int idTarifa, SimulacaoTarifa tarifa)
        {
            var tarifaEncontrada = _repository.GetById(idTarifa);
            var simulacao = tarifaEncontrada.Simulacoes
                .Where(x => x.StatusSimulacaoTarifa.Equals(StatusSimulacaoTarifa.Status.C))
                .FirstOrDefault();

            simulacao.RedefinirTarifa(tarifa);

            _simulacaoAppService.RedefinirSimulacao(simulacao);

            return tarifaEncontrada;
        }

        public Tarifa RegistrarSimulacao(int idTarifa, SimulacaoTarifa simulacao)
        {
            var tarifa = _repository.GetById(idTarifa);

            tarifa.Simulacoes.ToList().ForEach(s => 
            {
                s.StatusSimulacaoTarifa = StatusSimulacaoTarifa.Status.P;
            });

            Preco preco = new Preco();
            var origem = tarifa.Coleta.Cliente.Endereco.Uf;
            var destino = tarifa.Coleta.Endereco.Uf;
            var valor = preco.Precos[origem];

            simulacao.StatusSimulacaoTarifa = StatusSimulacaoTarifa.Status.P;
            simulacao.Data = new DateTime();
            simulacao.Valor = valor.Find(x => x.Sigla.Equals(destino)).Valor;

            tarifa.Simulacoes.Add(simulacao);

            return _repository.Update(tarifa);
        }
    }
}