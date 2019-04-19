using System.Collections.Generic;
using System.Linq;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleExpedicao;

namespace Cargo.Repository.Classes.ControleExpedicao
{
    public class ExpedicaoColetaRepository : Repository<ExpedicaoColeta>, IExpedicaoColetaRepository
    {
        public ExpedicaoColetaRepository(CargoContexto context) : base(context)
        {
        }
    }
}