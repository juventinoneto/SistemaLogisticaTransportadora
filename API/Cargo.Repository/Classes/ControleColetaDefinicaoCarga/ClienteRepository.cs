using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.Repository.Classes.ControleColetaDefinicaoCarga
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CargoContexto context) : base(context)
        {
        }
               
    }
}