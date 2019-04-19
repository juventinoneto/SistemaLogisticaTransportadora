using Cargo.DomainModel.Models.ControleExpedicao;
using System.Collections.Generic;

namespace Cargo.ApplicationService.Interfaces.ControleExpedicao
{
    public interface IExpedicaoColetaAppService : IAppService<ExpedicaoColeta>
    {
        IEnumerable<ExpedicaoColeta> RegistrarExpedicao(List<ExpedicaoColeta> expedicoesColeta);
    }
}