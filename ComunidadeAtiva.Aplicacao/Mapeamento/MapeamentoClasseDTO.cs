using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Aplicacao.Mapeamento
{
    public class MapeamentoClasseDTO : Profile
    {
        public MapeamentoClasseDTO() 
        {
            CreateMap<NecessidadeEspecial, NecessidadesDTO>().ReverseMap();
            CreateMap<BeneficioSocial, BeneficiosDTO>().ReverseMap();
            CreateMap<MoradorBeneficioSocial, BeneficosMoradorDTO>().ReverseMap();
            CreateMap<MoradorNecessidadeEspecial, NecessidadesMoradorDTO>().ReverseMap();
            CreateMap<CorpoDirigenteAssociacao, CorpoDirigenteAssociacaoDTO>().ReverseMap();
            CreateMap<Associacao, AssociacaoDTO>().ReverseMap();
            CreateMap<Morador, MoradorDTO>().ForMember(dest => dest.Cpf, opt => opt.MapFrom(src=> src.Cpf.CPF)).ReverseMap();
            CreateMap<Rua, RuaDTO>().ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Cep.CEP)).ReverseMap();
        }

    }
}
