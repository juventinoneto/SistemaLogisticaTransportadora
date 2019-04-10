using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.Repository.Classes.ControleColetaDefinicaoCarga
{
    public class ColetaRepository : Repository<Coleta>, IColetaRepository
    {
        public ColetaRepository(CargoContexto context) : base(context)
        {
        }
    }
}