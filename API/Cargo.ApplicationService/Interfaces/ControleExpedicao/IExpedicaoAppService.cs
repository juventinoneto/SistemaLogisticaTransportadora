using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using System.Collections.Generic;
using Cargo.ApplicationService.DTO.Commons;
using System;

namespace Cargo.ApplicationService.Interfaces.ControleExpedicao
{
    public interface IExpedicaoAppService : IAppService<Expedicao>
    {
        IEnumerable<Coleta> GetExpedicoesDiarias();

        ResultBase DefinirExpedicao(IEnumerable<int> idsColetas, DateTime data);
    }
}