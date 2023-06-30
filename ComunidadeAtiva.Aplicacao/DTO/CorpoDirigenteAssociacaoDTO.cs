using System.ComponentModel.DataAnnotations;


namespace ComunidadeAtiva.Aplicacao.DTO
{
    public class CorpoDirigenteAssociacaoDTO
    {
        public int IdAssociacao { get; set; }
        public int IdCargo { get; set; }      
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Ativo { get; set; }
        public string UsuarioId { get; set; }
      
        [Required(ErrorMessage = "E-mail é Obrigatório !")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é Obrigatória !")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirmação de senha é Obrigatória !")]
        public string ConfirmaSenha { get; set; }
        public string TokenJWT { get; set; }
        public string Erro { get; set; }
    }
}
