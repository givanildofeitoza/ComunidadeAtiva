using AutoMapper;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Aplicacao.Repositorio;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ComunidadeAtiva.Aplicacao.Mapeamento;


namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoRua
    {
        private readonly IruaRepositorio _ruaRepositorio;
        private readonly IMapper _mapper;
        private readonly ICapturarNotificacao _notificacao;
        public ServicoRua(IruaRepositorio ruaRepositorio, IMapper mapper, ICapturarNotificacao notificacao)
        {
            _ruaRepositorio = ruaRepositorio;
            _mapper = mapper;            
            _notificacao = notificacao;
        }
        public async void CadastrarRua(RuaDTO ruaDTO)
        {
            var rua = _mapper.Map<Rua>(ruaDTO);            
            rua.setCep(ruaDTO.Cep);
            rua.IsValid(_notificacao);

            await _ruaRepositorio.Cadastrar(rua);
        }
        public async void AlterarRua(RuaDTO ruaDTO)
        {
            var rua = _mapper.Map<Rua>(ruaDTO);
            rua.setCep(ruaDTO.Cep);
            rua.IsValid(_notificacao);

            await _ruaRepositorio.Alterar(_mapper.Map<Rua>(rua));
        }


    }
}
