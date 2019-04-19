using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using System.Collections.Generic;

namespace Cargo.ApplicationService.Interfaces.ControleExpedicao
{
    public interface IExpedicaoAppService : IAppService<Expedicao>
    {
        IEnumerable<Coleta> GetExpedicoesDiarias();
    }
}