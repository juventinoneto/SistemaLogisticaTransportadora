using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe.ControleExpedicao
{
    public class ExpedicaoColetaAppService : AppService<ExpedicaoColeta>, IExpedicaoColetaAppService
    {
        public ExpedicaoColetaAppService(IRepository<ExpedicaoColeta> repository) : base(repository)
        {
        }
    }
}