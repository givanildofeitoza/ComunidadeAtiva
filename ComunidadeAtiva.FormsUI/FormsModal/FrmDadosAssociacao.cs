using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Exceptions;
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
    public partial class FrmDadosAssociacao : Form
    {
        private AssociacaoDTO associacaoDTO = new AssociacaoDTO();
        private int _id = 0;
        public FrmDadosAssociacao()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            associacaoDTO.RazaoSocial = txtRazao.Text;
            associacaoDTO.NomeFantasia = txtFantasia.Text;
            associacaoDTO.Representante1 = txtPresidente.Text;
            associacaoDTO.Representante2 = txtVicePresidente.Text;
            associacaoDTO.Cnpj = txtCnpj.Text;
            associacaoDTO.Telefone = txtTelefone.Text;
            associacaoDTO.Endereco = txtEndereco.Text;
            associacaoDTO.Bairro = txtBairro.Text;
            associacaoDTO.Cidade = TxtCidade.Text;
            associacaoDTO.Email = txtEmail.Text;
            associacaoDTO.Site = TxtSite.Text;
            associacaoDTO.Estado = txEstado.Text.Substring(0,2);

            try
            {
                //IEnumerable<AssociacaoDTO> associacao = await FrmMain._ServicoAssociacao.ObterAssociacaoTodos(2, 0);
                AssociacaoDTO  associacao = await FrmMain._ServicoAssociacao.ObterAssociacaoPorId(_id);
                if (associacao is null)
                {
                    await FrmMain._ServicoAssociacao.CadastrarAssociacao(associacaoDTO);
                    MessageBox.Show("Dados Cadastrados com Sucesso !");
                }
                else
                {
                    associacaoDTO.Id = associacao.Id;
                    await FrmMain._ServicoAssociacao.AlterarAssociacao(associacaoDTO);
                    MessageBox.Show("Dados Alterados com Sucesso !");
                }

            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void FrmDadosAssociacao_Shown(object sender, EventArgs e)
        {
            IEnumerable<AssociacaoDTO> associacao = await FrmMain._ServicoAssociacao.ObterAssociacaoTodos(1, 0);
            if (associacao.Count() > 0)
            {
                txtRazao.Text = associacao.FirstOrDefault().RazaoSocial;
                txtFantasia.Text = associacao.FirstOrDefault().NomeFantasia;
                txtPresidente.Text = associacao.FirstOrDefault().Representante1;
                txtVicePresidente.Text = associacao.FirstOrDefault().Representante2;
                txtCnpj.Text = associacao.FirstOrDefault().Cnpj;
                txtTelefone.Text = associacao.FirstOrDefault().Telefone;
                txtEndereco.Text = associacao.FirstOrDefault().Endereco;
                txtBairro.Text = associacao.FirstOrDefault().Bairro;
                TxtCidade.Text = associacao.FirstOrDefault().Cidade;
                txtEmail.Text = associacao.FirstOrDefault().Email;
                TxtSite.Text = associacao.FirstOrDefault().Site;
                txEstado.Text = associacao.FirstOrDefault().Estado;
                _id = associacao.FirstOrDefault().Id;
            }

        }
    }
}
