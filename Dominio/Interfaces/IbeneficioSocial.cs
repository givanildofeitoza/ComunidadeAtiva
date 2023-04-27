using ComunidadeAtiva.Dominio.Entity;


namespace ComunidadeAtiva.Dominio.Interfaces
{
    public interface IbeneficioSocialService
    {
        public void CadastrarBeneficioSocial(BeneficioSocial b);
        public void AlterarBeneficioSocialr(BeneficioSocial b);
        public IEnumerable<BeneficioSocial> ObterTodosBeneficioSocial(int t, int s);
        public BeneficioSocial ObterBeneficioSocialId(int id);
    }
}
