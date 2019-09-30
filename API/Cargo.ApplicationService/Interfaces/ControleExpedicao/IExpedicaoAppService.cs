using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using System.Collections.Generic;
using Cargo.ApplicationService.DTO.Commons;
using System;
using Cargo.ApplicationService.DTO.ControleExpedicao;

namespace Cargo.ApplicationService.Interfaces.ControleExpedicao
{
    public interface IExpedicaoAppService : IAppService<Expedicao>
    {
        IEnumerable<Coleta> GetExpedicoesDiarias();

        Expedicao DefinirExpedicao(RegistrarExpedicaoCommand request, Coleta coleta);
    }
}