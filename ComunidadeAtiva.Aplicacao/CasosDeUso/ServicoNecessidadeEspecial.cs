using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServicoNecessidadeEspecial : IServicoNecessidadeEspecial
    {

        private readonly IMapper _mapper;
        private readonly InecessidadeEspecialRepositorio _servicoNecessidadeEspecial;
        private readonly ICapturarNotificacao _notificacao;

        public ServicoNecessidadeEspecial(IMapper mapper, InecessidadeEspecialRepositorio servicoNecessidadeEspecial, ICapturarNotificacao notificacao)
        {
            _mapper = mapper;
            _servicoNecessidadeEspecial = servicoNecessidadeEspecial;
            _notificacao = notificacao;
        }

        public async Task AlterarNecessidade(NecessidadesDTO necessidadeDTO)
        {
            var necessidade = _mapper.Map<NecessidadeEspecial>(necessidadeDTO);
            necessidade.Validar(_notificacao);
            EmitirExcecoes.EmitirExcecao(_notificacao);

            await _servicoNecessidadeEspecial.Alterar(_mapper.Map<NecessidadeEspecial>(necessidadeDTO));
        }

        public async Task CadastrarNecessidade(NecessidadesDTO necessidadeDTO)
        {
            var necessidade = _mapper.Map<NecessidadeEspecial>(necessidadeDTO);
            necessidade.Validar(_notificacao);
            EmitirExcecoes.EmitirExcecao(_notificacao);

            await _servicoNecessidadeEspecial.Cadastrar(necessidade);
        }

        public async Task DeletarNecessidade(NecessidadesDTO necessidadeDTO)
        {
            await _servicoNecessidadeEspecial.Deletar(_mapper.Map<NecessidadeEspecial>(necessidadeDTO));
        }

        public async Task<NecessidadesDTO> ObterNecessidadeID(int Id)
        {
            return _mapper.Map<NecessidadesDTO>(await _servicoNecessidadeEspecial.ObterPorId(Id));
        }

        public async Task<IEnumerable<NecessidadesDTO>> ObterNecessidadeTodos(int take, int skip)
        {
            return _mapper.Map< IEnumerable<NecessidadesDTO>>(await _servicoNecessidadeEspecial.ObterTodos(take,skip));
        }
    }
}
