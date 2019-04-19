using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using System;
using System.Collections.Generic;

namespace Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga
{
    public interface IColetaAppService : IAppService<Coleta>
    {
        Coleta RegistrarColeta(Coleta coleta);

        IEnumerable<Coleta> GetColetasDataAtual(DateTime data);
    }
}