using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.ApplicationService.Classe.ControleColetaDefinicaoCarga
{
    public class ColetaAppService : AppService<Coleta>, IColetaAppService
    {
        private readonly IClienteRepository _clienteRepository;

        private readonly IParceiroRepository _parceiroRepository;

        public ColetaAppService(
            IColetaRepository repository,
            IClienteRepository clienteRepository,
            IParceiroRepository parceiroRepository
            ) : base(repository)
        {
            _clienteRepository = clienteRepository;
            _parceiroRepository = parceiroRepository;
        }

        public Coleta RegistrarColeta(Coleta coleta)
        {
            Coleta coletaRegistrada = base.Create(coleta);

            return coletaRegistrada;
        }
    }
}