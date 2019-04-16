using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.ApplicationService.Classe.ControleColetaDefinicaoCarga
{
    public class ClienteAppService : AppService<Cliente>, IClienteAppService
    {
        public ClienteAppService(IClienteRepository repository) : base(repository)
        {
        }
    }
}