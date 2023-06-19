using System.ComponentModel.DataAnnotations;


namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class CorpoDirigenteAssociacaoDTO
    {
        public int IdAssociacao { get; set; }
        public int IdCargo { get; set; }
        [Required]
        public string Nome { get; set; }
        public string? Apelido { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Ativo { get; set; }
        [Required]
        public string UsuarioId { get; set; }
    }
}
