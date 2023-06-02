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
    public class ServicoMorador : IServicoMorador
    {
        protected readonly ImoradorRepositorio _MoradorRepositorio;
        protected readonly IMapper _Mapper;
        protected readonly ICapturarNotificacao _Notificacao;


        public ServicoMorador(ImoradorRepositorio moradorRepositorio, IMapper mapper, ICapturarNotificacao notificacao)
        {
            _MoradorRepositorio = moradorRepositorio;
            _Mapper = mapper;
            _Notificacao = notificacao;
        }

        public async Task AlterarMorador(MoradorDTO m)
        {
            var Morador = _Mapper.Map<Morador>(m);
            Morador.SetCpf(m.Cpf);
            Morador.Validar(_Notificacao);

            await _MoradorRepositorio.Alterar(Morador);
        }

        public async Task CadastrarMorador(MoradorDTO m)
        {
            var Morador = _Mapper.Map<Morador>(m);
            Morador.SetCpf(m.Cpf);
            Morador.Validar(_Notificacao);
            await _MoradorRepositorio.Cadastrar(Morador);
        }

        public async Task DeletarMorador(MoradorDTO m)
        {            
            await _MoradorRepositorio.Deletar(_Mapper.Map<Morador>(m));
        }

        public async Task<MoradorDTO> ObterMoradorId(int Id)
        {
            return _Mapper.Map<MoradorDTO>(await _MoradorRepositorio.ObterPorId(Id));
        }

        public async Task<IEnumerable<MoradorDTO>> ObterMradorTodos(int skip, int take)
        {
            return _Mapper.Map<IEnumerable<MoradorDTO>>(await _MoradorRepositorio.ObterTodos(skip,take));
            
        }

        public async Task<MoradorDTO> ObterMoradorRelacionalRuaId(int Id)
        {
            return _Mapper.Map<MoradorDTO>(await _MoradorRepositorio.ObterMoradorRelacionalRuaId(Id));
            
        }
        public async Task<IEnumerable<MoradorDTO>> ObterTodosRelacionalMorador(int t, int s)
        {
            return _Mapper.Map<IEnumerable<MoradorDTO>>(await _MoradorRepositorio.ObterTodosRelacionalMorador(t,s));
            
        }
    }
}
