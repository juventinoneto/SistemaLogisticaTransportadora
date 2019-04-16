using Cargo.ApplicationService.Interfaces.ControleTabelaFrete;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe.ControleTabelaFrete
{
    public class TarifaAppService : AppService<Tarifa>, ITarifaAppService
    {
        public TarifaAppService(IRepository<Tarifa> repository) : base(repository)
        {
        }
    }
}