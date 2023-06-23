using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
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
    public class ServicoNecessidadeMorador : IServicoNecessidadeMorador
    {
        private readonly ImoradorNecessidadeEspecialRepositorio _MoradorNecessidadeEspecialRepositorio;
        private readonly IMapper _Mapper;
        private readonly ICapturarNotificacao _Notificacao; 


        public ServicoNecessidadeMorador(ImoradorNecessidadeEspecialRepositorio moradorNecessidadeEspecialRepositorio,
            IMapper Mapper,
            ICapturarNotificacao notificacao)
        {
            _Mapper = Mapper;
            _MoradorNecessidadeEspecialRepositorio = moradorNecessidadeEspecialRepositorio;
            _Notificacao = notificacao;
        }

        public async Task AlterarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto)
        {
            var morador = _Mapper.Map<MoradorNecessidadeEspecial>(MoradorDto);
            morador.Validar(_Notificacao);
            EmitirExcecoes.EmitirExcecao(_Notificacao);

            await _MoradorNecessidadeEspecialRepositorio.Alterar(morador);
        }

        public async Task CadastrarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto)
        {
            var morador = _Mapper.Map<MoradorNecessidadeEspecial>(MoradorDto);
            morador.Validar(_Notificacao);
            EmitirExcecoes.EmitirExcecao(_Notificacao);

            await _MoradorNecessidadeEspecialRepositorio.Cadastrar(morador);
        }

        public async Task DeletarNecessidadeMorador(NecessidadesMoradorDTO MoradorDto)
        {
            var morador = _Mapper.Map<MoradorNecessidadeEspecial>(MoradorDto);
            morador.Validar(_Notificacao);
            EmitirExcecoes.EmitirExcecao(_Notificacao);

            await _MoradorNecessidadeEspecialRepositorio.Deletar(morador);
        }

        public async Task<NecessidadesMoradorDTO> ObterNecessidadeMoradorId(int Id)
            =>_Mapper.Map<NecessidadesMoradorDTO>(await _MoradorNecessidadeEspecialRepositorio.ObterPorId(Id));       
        
        public async Task<IEnumerable<NecessidadesMoradorDTO>> ObterNecessidadeMoradorTodos(int skip, int take)
            =>_Mapper.Map< IEnumerable<NecessidadesMoradorDTO>>(await _MoradorNecessidadeEspecialRepositorio.ObterTodos(skip,take));

        public async Task DeletarNecessidadePorIdNecessidade(int Id)
        {
            await _MoradorNecessidadeEspecialRepositorio.DeletarNecessidadePorIdNecessidade(Id);
        }
    }
}
