using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    
    public class ServicoBeneficoSocialMorador : IServicoBeneficoSocialMorador
    {
        private readonly ImoradorBeneficioSocialRepositorio _MoradorBeneficioSocialRepositorio;
        private readonly IMapper _Mapper;
        public ServicoBeneficoSocialMorador(ImoradorBeneficioSocialRepositorio MoradorBeneficioSocialRepositorio, IMapper Mapper)
        {
            _MoradorBeneficioSocialRepositorio = MoradorBeneficioSocialRepositorio;
            _Mapper = Mapper;
        }

        public async Task AlterarBeneficioMorador(BeneficosMoradorDTO beneficoDTO)
        {
            await _MoradorBeneficioSocialRepositorio.Alterar(_Mapper.Map<MoradorBeneficioSocial>(beneficoDTO));
        }

        public async Task CadastrarBeneficioMorador(BeneficosMoradorDTO beneficoDTO)
        {
            await _MoradorBeneficioSocialRepositorio.Cadastrar(_Mapper.Map<MoradorBeneficioSocial>(beneficoDTO));
        }

        public async Task DeletarBeneficioMorador(BeneficosMoradorDTO beneficoDTO)
        {
           await _MoradorBeneficioSocialRepositorio.Deletar(_Mapper.Map<MoradorBeneficioSocial>(beneficoDTO));
        }

        public async Task<BeneficosMoradorDTO> ObterBeneficioMoradorID(int Id)
        {
           return _Mapper.Map<BeneficosMoradorDTO>(await _MoradorBeneficioSocialRepositorio.ObterPorId(Id));
        }

        public async Task<IEnumerable<BeneficosMoradorDTO>> ObterBeneficioMoradorTodos(int skip, int take)
        {
           return _Mapper.Map<IEnumerable<BeneficosMoradorDTO>>(await _MoradorBeneficioSocialRepositorio.ObterTodos(skip,take));
        }
    }
}
