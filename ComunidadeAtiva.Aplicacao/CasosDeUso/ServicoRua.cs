using AutoMapper;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoRua : IServicoRua
    {
        protected readonly IruaRepositorio _ruaRepositorio;
        protected readonly IMapper _mapper;
        protected readonly ICapturarNotificacao _notificacao;
        public ServicoRua(IruaRepositorio ruaRepositorio, IMapper mapper, ICapturarNotificacao notificacao)
        {
            _ruaRepositorio = ruaRepositorio;
            _mapper = mapper;            
            _notificacao = notificacao;
        }
        public async Task CadastrarRua(RuaDTO ruaDTO)
        {
            var rua = _mapper.Map<Rua>(ruaDTO);            
            rua.setCep(ruaDTO.Cep);
            rua.IsValid(_notificacao);

            await _ruaRepositorio.Cadastrar(rua);
        }
        public async Task AlterarRua(RuaDTO ruaDTO)
        {
            var rua = _mapper.Map<Rua>(ruaDTO);
            rua.setCep(ruaDTO.Cep);
            rua.IsValid(_notificacao);

            await _ruaRepositorio.Alterar(rua);
        }

        public async Task<RuaDTO> ObterRuaPorId(int Id)
        {
            return  _mapper.Map<RuaDTO>(await _ruaRepositorio.ObterPorId(Id));
        }

        public async Task<IEnumerable<RuaDTO>> ObterRuaTodas(int take, int skip)
        {
            return  _mapper.Map<IEnumerable<RuaDTO>>(await _ruaRepositorio.ObterTodos(take, skip));
        }

        public async Task ApagarRua(RuaDTO ruaDTO)
        {
            await _ruaRepositorio.Deletar(_mapper.Map<Rua>(ruaDTO));
        }

    }
}
