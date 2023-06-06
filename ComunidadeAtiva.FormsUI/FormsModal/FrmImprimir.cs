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
        public string texto = "";
        private int linha = 1;
        private int ultimaPagina = 1;
        private int PaginaImpressa = 0;
        private List<LinhaImpressao> TextoImpressao = new List<LinhaImpressao>();



        private async void impressao_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font tipo_Font_Corpo = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush CorCorpo = new SolidBrush(Color.Black);
            var totalLinha = TextoImpressao.Max(x => x.inc);
            var totalPag = TextoImpressao.Max(x => x.pag);

            while (linha < 55)
            {

                if (TextoImpressao.Count(x => x.linha == linha && x.pag == ultimaPagina) > 0)
                {
                    LinhaImpressao item = TextoImpressao.Where(x => x.linha == linha && x.pag == ultimaPagina).FirstOrDefault();
                    Point PontoImpressaoCorpo = new Point(50, 30 * item.linha);
                    e.Graphics.DrawString(item.valor, tipo_Font_Corpo, CorCorpo, PontoImpressaoCorpo);

                    linha += 1;
                }
                else { break; }
            }

            if (ultimaPagina < totalPag)
            {
                linha = 1;
                ultimaPagina += 1;
                e.HasMorePages = true;
            }


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TextoImpressao.Clear();
            var moradores = await FrmMain._ServicoMorador.ObterMradorTodos(50, 0);
            var descricaoBeneficios = await FrmMain._beneficioSocial.ObterTodos(50, 0);
            var descricaoNecessidades = await FrmMain._necessidadeEspecial.ObterTodos(50, 0);

            RGprint rgPrint = new RGprint(true, 55);
            rgPrint.impCabecalho("LISTAGEM DE MORADORES", 15, FontStyle.Bold, 16);
            rgPrint.impCabecalho("CABEÇALHO 02", 1, FontStyle.Regular, 16);
            rgPrint.impCabecalho("CABEÇALHO 03", 1, FontStyle.Regular, 16);
            rgPrint.impCabecalho("CABEÇALHO 04", 1, FontStyle.Regular, 16);
            rgPrint.impCabecalho("--------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Bold, 16);

            foreach (var impMorador in moradores)
            {
                rgPrint.impLinha(impMorador.Nome!, 1, FontStyle.Bold, 16);
                if (chkBenefico.Checked)
                {
                    rgPrint.impLinha("Benefícios Sociais:", 1, FontStyle.Regular, 16);
                    var beneficio = await FrmMain._ServicoBeneficoSocialMorador.ObterBeneficioMoradorTodos(50, 0);
                    foreach (var b in (beneficio.Where(x => x.MoradorId == int.Parse(impMorador.id))))
                    {
                        rgPrint.impLinha(descricaoBeneficios.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial + "  Valor R$: " + b.Valor, 1, FontStyle.Regular, 16);
                    }
                    rgPrint.impLinha("", 1, FontStyle.Regular, 16); 

                }
                if (chkNecessidade.Checked)
                {
                    rgPrint.impLinha("Necessidades Especiais(Necessita Remédio?):", 1, FontStyle.Regular, 16);
                    var necessidade = await FrmMain._ServicoNecessidadeMorador.ObterNecessidadeMoradorTodos(50, 0);
                    foreach (var n in (necessidade.Where(x => x.MoradorId == int.Parse(impMorador.id))))
                    {
                        var bene = descricaoNecessidades.Where(x => x.id == n.NecessidadeId).FirstOrDefault();
                        rgPrint.impLinha(bene.DescricaoNecessidadeEspecial + "(" + bene.NecessitaRemedioControlado + ")", 1, FontStyle.Regular, 16);
                    }
                    rgPrint.impLinha("", 1, FontStyle.Regular, 16); 
                }

            }
            rgPrint.Imprimir();
          
        }

    }
}
