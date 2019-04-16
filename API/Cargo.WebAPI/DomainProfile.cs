using AutoMapper;
using Cargo.ApplicationService.DTO.Commons;
using Cargo.ApplicationService.DTO.ControleColetaDefinicaoCarga;
using Cargo.DomainModel.Models.Commons;
using Cargo.DomainModel.Models.ControleColetaDefinicaoCarga;

namespace Cargo.ApplicationService.DTO
{
    public class DomainProfile : Profile
    {
        public DomainProfile() 
        {
            CreateMap<SolicitarColetaClienteCommand, Cliente>().ReverseMap();
            CreateMap<SolicitarColetaParceiroCommand, Parceiro>().ReverseMap();
            CreateMap<SolicitarColetaCommand, Coleta>().ReverseMap();

            CreateMap<Endereco, EnderecoData>().ReverseMap();
            CreateMap<Cliente, ClienteData>().ReverseMap();
        }
        
    }
}