using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.DTO.ControleExpedicao;
using Cargo.DomainModel.Models.ControleExpedicao;
using Cargo.DomainModel.Models.ControleTabelaFrete;
using Cargo.ApplicationService.DTO.ControleTabelaFrete;

namespace Cargo.ApplicationService.DTO
{
    public class DomainProfile : Profile
    {
        public DomainProfile() 
        {
            CreateMap<RegistrarSimulacaoTarifaCommand, SimulacaoTarifa>();
            CreateMap<RegistrarTarifaCommand, Tarifa>();
            CreateMap<TarifaData, Tarifa>();

            CreateMap<ColetaData, Coleta>().ReverseMap();

            CreateMap<ColetaData, Coleta>().ReverseMap();
            CreateMap<RegistrarExpedicaoColetaCommand, ExpedicaoColeta>();

            CreateMap<SolicitarColetaClienteCommand, Cliente>().ReverseMap();
            CreateMap<SolicitarColetaParceiroCommand, Parceiro>().ReverseMap();
            CreateMap<SolicitarColetaCommand, Coleta>().ReverseMap();

            CreateMap<Endereco, EnderecoData>().ReverseMap();
            CreateMap<Cliente, ClienteData>().ReverseMap();
        }
        
    }
}