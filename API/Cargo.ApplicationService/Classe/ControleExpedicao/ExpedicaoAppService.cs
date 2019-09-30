using System;
using System.Collections.Generic;
using System.Linq;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces.ControleExpedicao;

namespace Cargo.ApplicationService.Classe.ControleExpedicao
{
    public class ExpedicaoAppService : AppService<Expedicao>, IExpedicaoAppService
    {
        private readonly IColetaAppService _coletaAppService;
        public ExpedicaoAppService(
            IExpedicaoRepository repository,
            IColetaAppService coletaAppService
            ) : base(repository)
        {
            _coletaAppService = coletaAppService;
        }

        public Expedicao DefinirExpedicao(RegistrarExpedicaoCommand request, Coleta coleta)
        {
            var expedicao = Expedicao.Criar(coleta, request.Data);
            var retorno = base.Create(expedicao);

            return retorno;
        }

        public IEnumerable<Coleta> GetExpedicoesDiarias()
        {
            var expedicoes = _coletaAppService.GetColetasDataAtual(new DateTime());

            return expedicoes.ToList();
        }
    }
}