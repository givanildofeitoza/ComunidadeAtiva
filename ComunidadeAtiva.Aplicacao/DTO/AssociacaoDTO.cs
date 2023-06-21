namespace ComunidadeAtiva.Aplicacao.CasosDeUso.Interface
{
    public class AssociacaoDTO
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Representante1 { get; set; }
        public string Representante2 { get; set; }
        public int AnoPosse { get; set; }
        public int AnoFimMandato { get; set; }
    }
}