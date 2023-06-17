using System.Data;
using ComunidadeAtiva.FormsUI.Classes;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class FrmImprimir : Form
    {
        public FrmImprimir()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var moradores = await FrmMain._ServicoMorador.ObterTodosRelacionalMorador(5000, 0);
            var descricaoBeneficios = await FrmMain._beneficioSocial.ObterTodos(100, 0);
            var descricaoNecessidades = await FrmMain._necessidadeEspecial.ObterTodos(100, 0);

            if (cboTipo.Text.Substring(0, 2) == "01")
            {
                moradores = moradores.Where(x => x.necessidadeEspecial.Count() > 0).ToList();
            }
            switch ( int.Parse(cboOrdem.Text.Substring(0, 1))) 
            {
                case 0:
                    {
                        moradores = moradores.OrderBy(x => x.Nome).ToList();
                        break;
                    }
                case 1:
                    {
                        moradores = moradores.OrderBy(x => x.RuaId).ToList();
                        break;
                    }

            }

            RGprint rgPrint = new RGprint(true, 55);
            rgPrint.impCabecalho("LISTAGEM DE MORADORES", 15, FontStyle.Bold, 16, true);
            rgPrint.impCabecalho("CABEÇALHO 02", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("CABEÇALHO 03", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("Tipo de Relatório: " + cboTipo.Text, 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("=================================================================================", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("[ MORADOR                                                           ][ RUA                                                           ]", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("=================================================================================", 1, FontStyle.Regular, 16, true);
           
            foreach (var impMorador in moradores)
            {
                rgPrint.impLinha(impMorador.id.ToString()+" - "+impMorador.Nome!, 1, FontStyle.Regular, 15, true);
                if (chkRua.Checked)
                {
                    var ruaNomenclaturas = await FrmMain._ruaService.ObterRuaTodas(500, 0);                   
                    var rua = ruaNomenclaturas.Where(x => x.id == impMorador.RuaId).FirstOrDefault();
                    rgPrint.impLinha(rua.Nome1, 20, FontStyle.Regular, 15, false);                
                }
                if (chkBenefico.Checked)
                {
                    var beneficio = await FrmMain._ServicoBeneficoSocialMorador.ObterBeneficioMoradorTodos(500, 0);
                    if (impMorador.moradorBeneficioSocial.Count() > 0)
                    {
                        rgPrint.impLinha("Benefícios Sociais:", 3, FontStyle.Bold, 16, true);
                        foreach (var b in impMorador.moradorBeneficioSocial)
                        {
                            rgPrint.impLinha(descricaoBeneficios.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial + "  Valor R$: " + b.Valor, 3, FontStyle.Regular, 16, true);
                            rgPrint.impLinha("------------------------------------------------------------------------------------------------------", 3, FontStyle.Regular,20, true);
                        }
                        rgPrint.impLinha("", 1, FontStyle.Regular, 16, true);
                    }

                }
                if (chkNecessidade.Checked)
                {
                    var necessidade = await FrmMain._ServicoNecessidadeMorador.ObterNecessidadeMoradorTodos(500, 0);
                    if (impMorador.necessidadeEspecial.Count() > 0)
                    {                       
                        rgPrint.impLinha("Necessidades Especiais:", 3, FontStyle.Bold, 16, true);
                        foreach (var n in impMorador.necessidadeEspecial)
                        {
                            var ne = descricaoNecessidades.Where(x => x.id == n.NecessidadeId).FirstOrDefault();
                            rgPrint.impLinha(ne.DescricaoNecessidadeEspecial, 3, FontStyle.Regular, 16, true);
                            rgPrint.impLinha("Remédio: " + ne.NecessitaRemedioControlado, 20, FontStyle.Regular, 16, false);
                            rgPrint.impLinha("----------------------------------------------------------------------------------------------------", 3, FontStyle.Regular, 20, true);
                        }

                    }
                    rgPrint.impLinha("", 1, FontStyle.Regular, 16, true);
                }               

            }
            rgPrint.impLinha("=================================================================================", 1, FontStyle.Regular, 16, true);
            rgPrint.impLinha("Total de Moradores: " + moradores.Count().ToString(), 1, FontStyle.Bold, 16, true);
            rgPrint.Imprimir();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
