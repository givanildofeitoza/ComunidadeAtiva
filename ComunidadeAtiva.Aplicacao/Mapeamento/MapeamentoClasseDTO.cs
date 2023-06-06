using AutoMapper;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.Mapeamento
{
    public class MapeamentoClasseDTO : Profile
    {
        public MapeamentoClasseDTO() 
        {
            CreateMap<BeneficioSocial, BeneficiosDTO>().ReverseMap();
            CreateMap<MoradorBeneficioSocial, BeneficosMoradorDTO>().ReverseMap();
            CreateMap<MoradorNecessidadeEspecial, NecessidadesMoradorDTO>().ReverseMap();
            CreateMap<Morador, MoradorDTO>().ForMember(dest => dest.Cpf, opt => opt.MapFrom(src=> src.Cpf.CPF)).ReverseMap();
            CreateMap<Rua, RuaDTO>().ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Cep.CEP)).ReverseMap();
        }

    }
}
