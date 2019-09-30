using System;
using System.Collections.Generic;
using System.Linq;
using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Util;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;

namespace Cargo.ApplicationService.Classe.ControleColetaDefinicaoCarga
{
    public class ColetaAppService : AppService<Coleta>, IColetaAppService
    {
        private readonly IColetaRepository _repository;

        private readonly IClienteRepository _clienteRepository;

        private readonly IParceiroRepository _parceiroRepository;

        public ColetaAppService(
            IColetaRepository repository,
            IClienteRepository clienteRepository,
            IParceiroRepository parceiroRepository
            ) : base(repository)
        {
            _repository = repository;
            _clienteRepository = clienteRepository;
            _parceiroRepository = parceiroRepository;
        }

        public IEnumerable<Coleta> GetAllColetas()
        {
            return _repository.GetAllColetas();
        }

        public IEnumerable<Coleta> GetColetasDataAtual(DateTime data)
        {
            return _repository.GetColetasDataAtual(data)
                .ToList();
        }

        public IEnumerable<ExpedicaoCalendarData> ListarColetasExpedicoes()
        {
            var coletas = GetAllColetas();
            List<ExpedicaoCalendarData> calendar = new List<ExpedicaoCalendarData>();

            coletas.ToList().ForEach(c =>
            {
                ExpedicaoCalendarData e = new ExpedicaoCalendarData();
                e.Data = c.Data;
                e.Destinatario = c.NomeDestinatario;
                e.IdColeta = c.IdColeta;

                Distancia distancia = new Distancia();
                var origem = c.Cliente.Endereco.Uf;
                var destino = c.Endereco.Uf;
                var valor = distancia.Distancias[origem].FirstOrDefault(x => x.Sigla.Equals(destino)).Valor;

                var diferencaDatas = c.Data.AddDays(valor).Subtract(DateTime.Now).TotalDays;

                e.DiasRestantes = (int) diferencaDatas;

                calendar.Add(e);
            });

            return calendar;
        }

        public Coleta RegistrarColeta(Coleta coleta)
        {
            Coleta coletaRegistrada = base.Create(coleta);

            return coletaRegistrada;
        }
    }
}