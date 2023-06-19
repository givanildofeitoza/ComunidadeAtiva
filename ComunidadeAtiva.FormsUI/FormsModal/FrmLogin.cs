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
        UsuarioDTO usuarioDTO = new UsuarioDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioDTO.Email = txtEmail.Text;
                usuarioDTO.Senha = txtSenha.Text;
                usuarioDTO.ConfirmaSenha = txtSenha.Text;

                if (await FrmMain._ServiceSegurancaIdentity.FazerLoginForms(usuarioDTO) == true)
                {
                    this.Close();
                    FrmMain.UsuarioLogado = txtEmail.Text;
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

            ConsoleKeyInfo key;
            key = Console.ReadKey(true); // lê a primeira tecla pressionada
            if (key.Key == ConsoleKey.F1) // verifica se é F1
            {
                key = Console.ReadKey(true); // lê a segunda tecla pressionada
                if (key.Key == ConsoleKey.F2) // verifica se é F2
                {
                    FrmCadMembro frmCadMembro = new FrmCadMembro();
                    frmCadMembro.ShowDialog();
                }
            }         

        }
    }
}
