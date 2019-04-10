using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleTabelaFrete;

namespace Cargo.Repository.Classes.ControleTabelaFrete
{
    public class TarifaRepository : Repository<Tarifa>, ITarifaRepository
    {
        public TarifaRepository(CargoContexto context) : base(context)
        {
        }
    }
}