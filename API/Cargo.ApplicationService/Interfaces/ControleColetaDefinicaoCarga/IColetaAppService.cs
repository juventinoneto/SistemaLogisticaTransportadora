using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga
{
    public interface IColetaAppService : IAppService<Coleta>
    {
        Coleta RegistrarColeta(Coleta coleta);
    }
}