using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoBeneficioSocial : IServicoBeneficioSocial
    {
        private readonly IbeneficioSocialRepositorio _beneficioSocial;
        private readonly IMapper _mapper;

        public ServicoBeneficioSocial(IbeneficioSocialRepositorio beneficioSocial, IMapper mapper)
        {
            _beneficioSocial = beneficioSocial;
            _mapper = mapper;
        }

        public async Task AlterarBeneficio(BeneficiosDTO beneficoDTO)
        {
            await _beneficioSocial.Alterar(_mapper.Map<BeneficioSocial>(beneficoDTO));
        }

        public async Task CadastrarBeneficio(BeneficiosDTO beneficoDTO)
        {
            await _beneficioSocial.Cadastrar(_mapper.Map<BeneficioSocial>(beneficoDTO));
        }

        public async Task DeletarBeneficio(BeneficiosDTO beneficoDTO)
        {
            await _beneficioSocial.Deletar(_mapper.Map<BeneficioSocial>(beneficoDTO));
        }

        public async Task<BeneficiosDTO> ObterBeneficioID(int Id)
            =>  _mapper.Map<BeneficiosDTO>(await _beneficioSocial.ObterPorId(Id));
        

        public async Task<IEnumerable<BeneficiosDTO>> ObterBeneficioTodos(int take, int skip)
            => _mapper.Map<IEnumerable<BeneficiosDTO>>(await _beneficioSocial.ObterTodos(take,skip));

    }
}
