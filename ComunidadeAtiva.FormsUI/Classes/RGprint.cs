using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ComunidadeAtiva.FormsUI.Classes
{
    internal class RGprint
    {
        public RGprint(bool previsualizar, int qtdLinhas)
        {
            Previsualizar = previsualizar;
            QtdLinhas = qtdLinhas;
            ListTexto = new List<LinhaImpressao>();
            ListCabecalho = new List<LinhaImpressao>();
        }
        public  bool Previsualizar { get; private set; }
        public  int  QtdLinhas { get; private set; }
        private int  linha { get; set; } = 1;
        private int  ultimaPagina { get; set; } = 1;
        private List<LinhaImpressao> ListTexto { get; set; }
        private List<LinhaImpressao> ListCabecalho { get; set; }

        private void MontarImpressao(object sender, PrintPageEventArgs e)
        {            
            SolidBrush CorCorpo = new SolidBrush(Color.Black);            
            if (QtdLinhas == 0)
            {
                foreach (var t in ListTexto)
                {
                    Font tipo_Font_Corpo = new Font("Arial", t.fontTamanho, t.EstiloFonte, GraphicsUnit.Pixel);
                    Point PontoImpressaoCorpo = new Point(20 * t.coluna, 20 * t.linha);
                    e.Graphics.DrawString(t.valor, tipo_Font_Corpo, CorCorpo, PontoImpressaoCorpo);
                }
            }
            else
            {
                var totalLinha = ListTexto.Max(x => x.inc);
                var totalPag = ListTexto.Max(x => x.pag);

                while (linha <= QtdLinhas)
                {
                    if (ListTexto.Count(x => x.linha == linha && x.pag == ultimaPagina) == 0)
                    break;

                    List<LinhaImpressao> item = ListTexto.Where(x => x.linha == linha && x.pag == ultimaPagina).ToList();
                    foreach (var t in item)
                    {
                        Font tipo_Font_Corpo = new Font("Arial", t.fontTamanho, t.EstiloFonte, GraphicsUnit.Pixel);
                        Point PontoImpressaoCorpo = new Point(20 * t.coluna, 20 * t.linha);
                        e.Graphics.DrawString(t.valor, tipo_Font_Corpo, CorCorpo, PontoImpressaoCorpo);
                    }
                    linha += 1;
                                         
                }
                if (ultimaPagina < totalPag)
                {
                    linha = 1;
                    ultimaPagina += 1;
                    e.HasMorePages = true;
                }
            }
        }
        public void Imprimir()
        {
            PrintDocument p = new PrintDocument();
            p.PrintPage += MontarImpressao;
            
            if (Previsualizar==true)
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = p;
                MyPrintPreviewDialog.WindowState = FormWindowState.Maximized;
                MyPrintPreviewDialog.ShowDialog();
            }
            else { p.Print(); }
            
        }
        public void impCabecalho(string pValor, int pColuna, FontStyle pEstilo, int pTamanho, bool pNovaLinha)
        {
            if(ListTexto.Count() == 0)
            ListCabecalho.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho = pTamanho, novaLinha = pNovaLinha});
        }
        public void impLinha(string pValor, int pColuna, FontStyle pEstilo, int pTamanho, bool pNovaLinha)
        {
            var maxPagina = ListTexto.Count() > 0 ? ListTexto.Max(x => x.pag) : 1;
            var ultLinha = ListTexto.Count() > 0 ? ListTexto.Where(x => x.pag == maxPagina).OrderByDescending(x => x.linha).FirstOrDefault().linha : 1;

            if (pNovaLinha == true && ultLinha > 1)
                ultLinha += 1;        

            if (ultLinha == 1)
            {
                if (ListCabecalho.Count() > 0)
                {
                    var maxPag = 1;
                    var ult_linha = 0;
                    foreach (var c in ListCabecalho)
                    {
                        if (c.novaLinha == true)
                        ult_linha += 1;
                                              
                        ListTexto.Add(new LinhaImpressao() { valor = c.valor, coluna = c.coluna, EstiloFonte = c.EstiloFonte, fontTamanho = c.fontTamanho, linha = ult_linha, pag = maxPag });
                    }
                    ultLinha = ult_linha+1;
                }
            }

            if (ultLinha == (QtdLinhas+1))
            {
                ultLinha = 1;
                if(ListCabecalho.Count() > 0)
                {
                    var maxPag = maxPagina + 1;
                    ultLinha = 0;
                    foreach (var c in ListCabecalho)
                    {
                      if (c.novaLinha == true)
                      ultLinha += 1;
                      
                      ListTexto.Add(new LinhaImpressao() { valor = c.valor, coluna = c.coluna, EstiloFonte = c.EstiloFonte, fontTamanho =c.fontTamanho, linha = ultLinha, pag = maxPag });
                    }
                    ultLinha += 1;
                    ListTexto.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho = pTamanho, linha = ultLinha, pag = maxPag });                    

                }
                else
                ListTexto.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho= pTamanho, linha = ultLinha, pag = maxPagina + 1 });                
            }
            else
                ListTexto.Add(new LinhaImpressao() { valor = pValor, coluna = pColuna, EstiloFonte = pEstilo, fontTamanho = pTamanho, linha = ultLinha, pag = maxPagina });
        }

    }
  
}
