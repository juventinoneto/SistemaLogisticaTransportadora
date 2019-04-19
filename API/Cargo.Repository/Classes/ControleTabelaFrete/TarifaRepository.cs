using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleTabelaFrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cargo.Repository.Classes.ControleTabelaFrete
{
    public class TarifaRepository : Repository<Tarifa>, ITarifaRepository
    {
        private readonly CargoContexto _context;
        public TarifaRepository(CargoContexto context) : base(context)
        {
            _context = context;
        }

        public Tarifa GetById(int idTarifa)
        {
            return _context
                .Tarifa
                .Include(x => x.Simulacoes)
                .Where(x => x.IdTarifa == idTarifa)
                .First();
                
        }
    }
}