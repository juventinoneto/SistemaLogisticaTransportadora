using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using System;
using System.Linq;

namespace Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga
{
    public interface IColetaRepository : IRepository<Coleta>
    {
        IQueryable<Coleta> GetColetasDataAtual(DateTime data);

        IQueryable<Coleta> GetAllColetas();
    }
}