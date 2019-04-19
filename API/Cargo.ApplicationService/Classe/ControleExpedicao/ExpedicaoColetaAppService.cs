using System.Collections.Generic;
using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleExpedicao;

namespace Cargo.ApplicationService.Classe.ControleExpedicao
{
    public class ExpedicaoColetaAppService : AppService<ExpedicaoColeta>, IExpedicaoColetaAppService
    {
        private readonly IExpedicaoColetaRepository _repository;

        public ExpedicaoColetaAppService(IExpedicaoColetaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<ExpedicaoColeta> RegistrarExpedicao(List<ExpedicaoColeta> expedicoesColeta)
        {
            var expedicoes = _repository.CreateList(expedicoesColeta);
            return expedicoes;
        }
    }
}