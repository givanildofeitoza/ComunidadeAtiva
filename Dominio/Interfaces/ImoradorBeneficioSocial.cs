using ComunidadeAtiva.Dominio.Entidades;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface ImoradorBeneficioSocialService
    {
        public void CadastrarMoradorBeneficioSocial(MoradorBeneficioSocial m);
        public void AlterarMoradorBeneficioSocial(MoradorBeneficioSocial m);
        public IEnumerable<MoradorBeneficioSocial> ObterTodosMoradorBeneficioSocial(int t, int s);
        public MoradorBeneficioSocial ObterMoradorBeneficioSocialId(int id);
    }
}
