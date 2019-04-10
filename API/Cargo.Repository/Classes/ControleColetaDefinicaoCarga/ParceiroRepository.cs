using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.Repository.Classes.ControleColetaDefinicaoCarga
{
    public class ParceiroRepository : Repository<Parceiro>, IParceiroRepository
    {
        public ParceiroRepository(CargoContexto context) : base(context)
        {
        }
    }
}