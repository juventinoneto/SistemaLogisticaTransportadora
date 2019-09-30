using System;
using System.Linq;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;
using Microsoft.EntityFrameworkCore;

namespace Cargo.Repository.Classes.ControleColetaDefinicaoCarga
{
    public class ColetaRepository : Repository<Coleta>, IColetaRepository
    {
        private readonly CargoContexto _context;

        public ColetaRepository(CargoContexto context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Coleta> GetAllColetas()
        {
            return _context
                .Coleta
                .Include(x => x.Cliente.Endereco)
                .Include(x => x.Parceiro.Endereco)
                .Include(x => x.Endereco)
                .Include(x => x.Tarifas);
        }

        public IQueryable<Coleta> GetColetasDataAtual(DateTime data)
        {
            return _context
                .Coleta
                .Where(x => x.Data.Day == data.Day && x.Data.Month == data.Month && data.Year == data.Year);
        }
    }
}