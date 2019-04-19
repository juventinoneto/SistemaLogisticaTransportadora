using System;
using System.Linq;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.Repository.Classes.ControleColetaDefinicaoCarga
{
    public class ColetaRepository : Repository<Coleta>, IColetaRepository
    {
        private readonly CargoContexto _context;

        public ColetaRepository(CargoContexto context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Coleta> GetColetasDataAtual(DateTime data)
        {
            return _context
                .Coleta
                .Where(x => x.Data.Day == data.Day && x.Data.Month == data.Month && data.Year == data.Year);
        }
    }
}