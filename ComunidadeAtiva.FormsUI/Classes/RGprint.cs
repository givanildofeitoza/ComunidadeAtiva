using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace ComunidadeAtiva.FormsUI.Classes
{
    internal class RGprint
    {
        public RGprint(bool previsualizar, int qtdLinhas)
        {
            Previsualizar = previsualizar;
            QtdLinhas = qtdLinhas;
            ListTexto = new List<LinhaImpressao>();
        }

        public bool Previsualizar { get; set; }
        public int  QtdLinhas { get; set; }
        private int linha { get; set; } = 1;
        private int ultimaPagina { get; set; } = 1;
        private PrintPreviewDialog PrevImpressor { get; set; }
        private PrintDocument PrintDocument { get; set; }
        private List<LinhaImpressao> ListTexto { get; set; }

        private void ExecutarImpressor(object sender, PrintPageEventArgs e)
        {
            
            SolidBrush CorCorpo = new SolidBrush(Color.Black);
            var totalLinha = ListTexto.Max(x => x.inc);
            var totalPag   = ListTexto.Max(x => x.pag);

            while (linha <= QtdLinhas)
            {
                if (ListTexto.Count(x => x.linha == linha && x.pag == ultimaPagina) > 0)
                {
                    LinhaImpressao item = ListTexto.Where(x => x.linha == linha && x.pag == ultimaPagina).FirstOrDefault();
                    Font tipo_Font_Corpo = new Font("Arial", item.fontTamanho, item.EstiloFonte, GraphicsUnit.Pixel);
                    Point PontoImpressaoCorpo = new Point(20 * item.coluna, 20 * item.linha);
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
        public void Imprimir()
        {
            PrintDocument p = new PrintDocument();
            p.PrintPage += ExecutarImpressor;
            
            if (Previsualizar==true)
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = p;
                MyPrintPreviewDialog.ShowDialog();
            }
            else { p.Print(); }
            
        }
        public void impLinha(string pValor, int pColuna, FontStyle pEstilo, int pTamanho)
        {
            var maxPagina = ListTexto.Count() > 0 ? ListTexto.Max(x => x.pag) : 1;

            var ultLinha = ListTexto.Count() > 0 ? ListTexto.Where(x => x.pag == maxPagina).OrderByDescending(x => x.linha).FirstOrDefault().linha + 1 : 1;

            var incValor = ListTexto.Count() + 1;

            if (ultLinha == (QtdLinhas+1))
            {
                ultLinha = 1;
                ListTexto.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho= pTamanho, linha = ultLinha, pag = maxPagina + 1,  inc = incValor });
                
            }
            else
                ListTexto.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho = pTamanho, linha = ultLinha, pag = maxPagina,  inc = incValor });
        }

    }
  
}
