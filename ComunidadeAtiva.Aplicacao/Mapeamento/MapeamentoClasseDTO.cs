using AutoMapper;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
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
            CreateMap<MoradorBeneficioSocial, BeneficosMoradorDTO>().ReverseMap();
            CreateMap<MoradorNecessidadeEspecial, NecessidadesMoradorDTO>().ReverseMap();
            CreateMap<Morador, MoradorDTO>().ReverseMap();
            CreateMap<Rua, RuaDTO>().ReverseMap();
        }

    }
}
