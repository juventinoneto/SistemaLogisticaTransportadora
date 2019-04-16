using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe.ControleColetaDefinicaoCarga
{
    public class ParceiroAppService : AppService<Parceiro>, IParceiroAppService
    {
        public ParceiroAppService(IRepository<Parceiro> repository) : base(repository)
        {
        }
    }
}