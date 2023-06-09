﻿using ComunidadeAtiva.Aplicacao.DTO;


namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public interface IServicoCorpoDirigenteAssociacao
    {
        public Task CadastrarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task AlterarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task DeletarDirigente(CorpoDirigenteAssociacaoDTO dirigenteDto);
        public Task<CorpoDirigenteAssociacaoDTO> ObterDirigentePorId(int Id);
        public Task<IEnumerable<CorpoDirigenteAssociacaoDTO>> ObterDirigenteTodos(int take, int skip);
        public Task<CorpoDirigenteAssociacaoDTO> ObterDirigenteRelacional(string Id);
    }
}
