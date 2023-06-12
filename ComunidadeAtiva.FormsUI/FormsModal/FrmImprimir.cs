using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
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
            var moradores = await FrmMain._ServicoMorador.ObterMradorTodos(50, 0);
            var descricaoBeneficios = await FrmMain._beneficioSocial.ObterTodos(50, 0);
            var descricaoNecessidades = await FrmMain._necessidadeEspecial.ObterTodos(50, 0);

            RGprint rgPrint = new RGprint(true, 55);
            rgPrint.impCabecalho("LISTAGEM DE MORADORES", 15, FontStyle.Bold, 16,true);
            rgPrint.impCabecalho("CABEÇALHO 02", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("CABEÇALHO 03", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("CABEÇALHO 04", 1, FontStyle.Regular, 16, true);
            rgPrint.impCabecalho("--------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Bold, 16, true);

            foreach (var impMorador in moradores)
            {
                rgPrint.impLinha(impMorador.Nome!, 1, FontStyle.Bold, 16, true);
                if (chkBenefico.Checked)
                {
                    rgPrint.impLinha("Benefícios Sociais:", 1, FontStyle.Regular, 16, true);
                    var beneficio = await FrmMain._ServicoBeneficoSocialMorador.ObterBeneficioMoradorTodos(50, 0);
                    foreach (var b in (beneficio.Where(x => x.MoradorId == int.Parse(impMorador.id))))
                    {
                        rgPrint.impLinha(descricaoBeneficios.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial + "  Valor R$: " + b.Valor, 1, FontStyle.Regular, 16, true);
                    }
                    rgPrint.impLinha("", 1, FontStyle.Regular, 16, true); 

                }
                if (chkNecessidade.Checked)
                {
                    rgPrint.impLinha("Necessidades Especiais(Necessita Remédio?):", 1, FontStyle.Regular, 16, true);
                    var necessidade = await FrmMain._ServicoNecessidadeMorador.ObterNecessidadeMoradorTodos(50, 0);
                    foreach (var n in (necessidade.Where(x => x.MoradorId == int.Parse(impMorador.id))))
                    {
                        var bene = descricaoNecessidades.Where(x => x.id == n.NecessidadeId).FirstOrDefault();
                        rgPrint.impLinha(bene.DescricaoNecessidadeEspecial + "(" + bene.NecessitaRemedioControlado + ")", 1, FontStyle.Regular, 16, true);
                    }
                    rgPrint.impLinha("", 1, FontStyle.Regular, 16, true); 
                }

            }
            rgPrint.Imprimir();
          
        }

    }
}
