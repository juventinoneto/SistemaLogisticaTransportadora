using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe.ControleExpedicao
{
    public class ExpedicaoAppService : AppService<Expedicao>, IExpedicaoAppService
    {
        public ExpedicaoAppService(IRepository<Expedicao> repository) : base(repository)
        {
        }
    }
}