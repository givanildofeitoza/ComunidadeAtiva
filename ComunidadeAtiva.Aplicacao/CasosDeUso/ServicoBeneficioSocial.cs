using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoBeneficioSocial : IServicoBeneficioSocial
    {
        protected readonly IbeneficioSocialRepositorio _beneficioSocial;
        protected readonly IMapper _mapper;
        protected readonly ICapturarNotificacao _notificacao;

        public ServicoBeneficioSocial(IbeneficioSocialRepositorio beneficioSocial, IMapper mapper, ICapturarNotificacao notificacao)
        {
            _beneficioSocial = beneficioSocial;
            _mapper = mapper;
            _notificacao = notificacao;
        }
        public async Task AlterarBeneficio(BeneficiosDTO beneficoDTO)
        {
            var beneficio = _mapper.Map<BeneficioSocial>(beneficoDTO);
            beneficio.Validar(_notificacao);          

            await _beneficioSocial.Alterar(beneficio);
        }

        public async Task CadastrarBeneficio(BeneficiosDTO beneficoDTO)
        {
            var beneficio = _mapper.Map<BeneficioSocial>(beneficoDTO);
            beneficio.Validar(_notificacao);         

            await _beneficioSocial.Cadastrar(beneficio);
        }

        public async Task DeletarBeneficio(BeneficiosDTO beneficoDTO)
        {
            var beneficio = _mapper.Map<BeneficioSocial>(beneficoDTO);
            beneficio.Validar(_notificacao);          

            await _beneficioSocial.Deletar(_mapper.Map<BeneficioSocial>(beneficio));
        }

        public async Task<BeneficiosDTO> ObterBeneficioID(int Id)
            =>  _mapper.Map<BeneficiosDTO>(await _beneficioSocial.ObterPorId(Id));
        

        public async Task<IEnumerable<BeneficiosDTO>> ObterBeneficioTodos(int take, int skip)
            => _mapper.Map<IEnumerable<BeneficiosDTO>>(await _beneficioSocial.ObterTodos(take,skip));

    }
}
