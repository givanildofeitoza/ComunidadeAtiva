using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoCorpoDirigenteAssociacao : ICorpoDirigenteAssociacao
    {
        protected readonly IcorpoDirigenteAssociacaoRepositorio _corpoDirigenteAssociacaoRepositorio;
        protected readonly IMapper _mapper;
        protected readonly ICapturarNotificacao _notificacao;
        public ServicoCorpoDirigenteAssociacao(IcorpoDirigenteAssociacaoRepositorio corpoDirigenteAssociacaoRepositorio, IMapper mapper, ICapturarNotificacao notificacao)
        {
            _corpoDirigenteAssociacaoRepositorio = corpoDirigenteAssociacaoRepositorio;
            _mapper = mapper;
            _notificacao = notificacao;

        }
        public async Task AlterarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            var dirigente = _mapper.Map<CorpoDirigenteAssociacao>(dirigenteDto);
            dirigente.Validar(_notificacao);
            EmitirExcecoes.EmitirExcecao(_notificacao);

            await _corpoDirigenteAssociacaoRepositorio.Alterar(dirigente);
        }

        public async Task CadastrarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            var dirigente = _mapper.Map<CorpoDirigenteAssociacao>(dirigenteDto);
            dirigente.Validar(_notificacao);
            EmitirExcecoes.EmitirExcecao(_notificacao);

            await _corpoDirigenteAssociacaoRepositorio.Cadastrar(dirigente);
        }

        public async Task DeletarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            var dirigente = _mapper.Map<CorpoDirigenteAssociacao>(dirigenteDto);
            await _corpoDirigenteAssociacaoRepositorio.Deletar(dirigente);
        }

        public async Task<CorpoDirigenteAssociacaoDTO> ObterDirigentePorId(int Id)
         => _mapper.Map<CorpoDirigenteAssociacaoDTO> (await _corpoDirigenteAssociacaoRepositorio.ObterPorId(Id));
        

        public async Task<IEnumerable<CorpoDirigenteAssociacaoDTO>> ObterDirigenteTodos(int take, int skip)
         => _mapper.Map< IEnumerable<CorpoDirigenteAssociacaoDTO>>(await _corpoDirigenteAssociacaoRepositorio.ObterTodos(take,skip));

        public async Task<CorpoDirigenteAssociacaoDTO> ObterDirigenteRelacional(string Id)
          => _mapper.Map<CorpoDirigenteAssociacaoDTO>(await _corpoDirigenteAssociacaoRepositorio.ObterDirigenteRelacional(Id));


    }
}
