using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.FormsUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class FrmCrudNecessidade : ClasseFormPadrao
    {
        private AcaoControleCadastro _AcaoControleCadastro;
        private NecessidadesDTO necessidade = new NecessidadesDTO();
        public FrmCrudNecessidade(AcaoControleCadastro acaoControleCadastro)
        {
            InitializeComponent();
            _AcaoControleCadastro = acaoControleCadastro;
        }

        private async void button4_Click(object sender, EventArgs e)
        {           
            necessidade.DescricaoNecessidadeEspecial = txtDescricao.Text;
            necessidade.Permanete = cboPermanente.Text;
            necessidade.NecessitaRemedioControlado = cboRemedio.Text;
            try
            {
                if (_AcaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
                    await FrmMain._ServicoNecessidadeEspecial.CadastrarNecessidade(necessidade);
                else
                    await FrmMain._ServicoNecessidadeEspecial.AlterarNecessidade(necessidade);
            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Solicitação Confirmada com Sucesso !");
            this.Close();
        }

        private async void FrmCrudNecessidade_Shown(object sender, EventArgs e)
        {
            if (_AcaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                pnlId.Visible = false;
                txtDescricao.Text = "";
                cboPermanente.Text = "N";
                cboRemedio.Text = "N";
            }
            else
            {
                necessidade = await FrmMain._ServicoNecessidadeEspecial.ObterNecessidadeID(Id);
                txtId.Text = necessidade.Id.ToString();
                txtDescricao.Text = necessidade.DescricaoNecessidadeEspecial;
                cboPermanente.Text = necessidade.Permanete;
                cboRemedio.Text = necessidade.NecessitaRemedioControlado;

            }

        }
    }
}
