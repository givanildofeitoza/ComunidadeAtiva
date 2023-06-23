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
    public partial class FrmLogin : Form
    {
        CorpoDirigenteAssociacaoDTO dirigenteDto = new CorpoDirigenteAssociacaoDTO();
        private int acessoRegistroUsuario = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dirigenteDto.Email = txtEmail.Text;
                dirigenteDto.Senha = txtSenha.Text;
                dirigenteDto.ConfirmaSenha = txtSenha.Text;
                var id = await FrmMain._ServiceSegurancaIdentity.FazerLoginForms(dirigenteDto);

                if (!string.IsNullOrEmpty(id))
                {
                    this.Close();
                    FrmMain.usuarioLogado.UsuarioId = id;
                }
                else
                {
                    MessageBox.Show("Erro ao tentar entrar! Verifique usuário e senha!");
                }
            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
                acessoRegistroUsuario += 1;
                if (acessoRegistroUsuario == 4)
                {
                    FrmCadMembro frmCadMembro = new FrmCadMembro();
                    frmCadMembro.ShowDialog();
                }
            }
            else
                acessoRegistroUsuario = 0;

        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
