using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
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
    public class ServicoAssociacao : IServicoAssociacao
    {
        private readonly IassociacaoRepositorio _AssociacaoRepositorio;
        private readonly IMapper _Mapper;
        private readonly ICapturarNotificacao _Notificacao;

        public ServicoAssociacao(IassociacaoRepositorio associacaoRepositorio, IMapper mapper, ICapturarNotificacao Notificacao)
        {
            _AssociacaoRepositorio = associacaoRepositorio;
            _Mapper = mapper;
            _Notificacao = Notificacao;
        }

        public async Task AlterarAssociacao(AssociacaoDTO associacao)
        {
            var a = _Mapper.Map<Associacao>(associacao);
            a.Validar(_Notificacao);
            EmitirExcecoes.EmitirExcecao(_Notificacao);

           await _AssociacaoRepositorio.Alterar(a);

        }

        public async Task CadastrarAssociacao(AssociacaoDTO associacao)
        {
            var a = _Mapper.Map<Associacao>(associacao);
            a.Validar(_Notificacao);
            EmitirExcecoes.EmitirExcecao(_Notificacao);

            await _AssociacaoRepositorio.Cadastrar(a);
        }

        public Task DeletarAssociacao(AssociacaoDTO associacao)
        {
            throw new NotImplementedException();
        }

        public async Task<AssociacaoDTO> ObterAssociacaoPorId(int Id)
          => _Mapper.Map<AssociacaoDTO>(await _AssociacaoRepositorio.ObterPorId(Id));

        public async Task<IEnumerable<AssociacaoDTO>> ObterAssociacaoTodos(int task, int skip)
          =>  _Mapper.Map<IEnumerable<AssociacaoDTO>>(await _AssociacaoRepositorio.ObterTodos(task,skip));
        
    }
}
