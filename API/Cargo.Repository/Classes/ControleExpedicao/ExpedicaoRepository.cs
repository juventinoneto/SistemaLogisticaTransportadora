using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleExpedicao;

namespace Cargo.Repository.Classes.ControleExpedicao
{
    public class ExpedicaoRepository : Repository<Expedicao>, IExpedicaoRepository
    {
        public ExpedicaoRepository(CargoContexto context) : base(context)
        {
        }
    }
}