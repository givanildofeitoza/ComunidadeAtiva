using ComunidadeAtiva.Aplicacao.CasosDeUso;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.FormsUI.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FormCrudBeneficioSocial : ClasseFormPadrao
    {
        private readonly AcaoControleCadastro _acaoControleCadastro;
        private BeneficiosDTO _beneficiosDTO = new BeneficiosDTO();
      
        public FormCrudBeneficioSocial(AcaoControleCadastro acaoControleCadastro)
        {
            InitializeComponent();
            _acaoControleCadastro = acaoControleCadastro;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (ValidarNumeros.ValidarDecimal(e.KeyChar.ToString(), txtvalor.Text) == false && (Keys)e.KeyChar != Keys.Back)
             //   e.Handled = true;
        }

        private async void FormCrudBeneficioSocial_Shown(object sender, EventArgs e)
        {
            if (_acaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                pnlId.Visible = false;
               txtNome.Text = "";
                txtDesc.Text = "";

            }
            else
            {
                _beneficiosDTO = await FrmMain._ServicoBeneficioSocial.ObterBeneficioID(Id);
                pnlId.Visible = true;
                txtId.Text = _beneficiosDTO.Id.ToString();
                txtNome.Text = _beneficiosDTO.NomeBeneficioSocial;
                txtDesc.Text = _beneficiosDTO.DescricaoBeneficioSocial;

            }

        }
        private async void button2_Click(object sender, EventArgs e)
        {
            _beneficiosDTO.NomeBeneficioSocial = txtNome.Text;
            _beneficiosDTO.DescricaoBeneficioSocial = txtDesc.Text;
            if (_acaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                try
                {
                    await FrmMain._ServicoBeneficioSocial.CadastrarBeneficio(_beneficiosDTO);
                }
                catch (ExcecoesCustomizadas ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    _beneficiosDTO.Id = int.Parse(txtId.Text);
                    await FrmMain._ServicoBeneficioSocial.AlterarBeneficio(_beneficiosDTO);
                }
                catch (ExcecoesCustomizadas ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            MessageBox.Show("Operação Confirmada Com Sucesso !");
            this.Close();
        }
    }
}
