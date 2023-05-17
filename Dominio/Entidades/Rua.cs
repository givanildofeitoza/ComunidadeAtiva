using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.ObjetoValor;
using ComunidadeAtiva.Dominio.Validacao;

namespace ComunidadeAtiva.Dominio.Entity
{
    public class Rua : Entidade
    {
        public Rua(string nome1, string nome2, string calcada, string energia, string agua, string saneamento, string coletaLixo, string agenteSaudeResponsval)
        {
            
            Nome1 = nome1;
            Nome2 = nome2;
            Calcada = calcada;
            Energia = energia;
            Agua = agua;
            Saneamento = saneamento;
            ColetaLixo = coletaLixo;
            AgenteSaudeResponsval = agenteSaudeResponsval;
        }

        public string Nome1 { get; set; }
        
        public string Nome2 { get; set; }

        public Cep Cep { get; private set; }

        public string Calcada { get; set; }
        
        public string Energia { get; set; }

        public string Agua { get; set; }

        public string Saneamento { get; set; }

        public string ColetaLixo { get; set; }

        public string AgenteSaudeResponsval { get; set; }

        public void setCep(string cep)
        {
            Cep = new Cep(cep);  
        } 

        public bool IsValid(ICapturarNotificacao notificacao)
        {
            notificacao.LimparErros();
                Cep.IsValid(notificacao);

            EmitirExcecoes.EmitirExcecao(notificacao);
        
            return true;
        }
    }
}
