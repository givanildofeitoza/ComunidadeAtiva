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
    public partial class FrmCadMembro : Form
    {
        private UsuarioDTO usuario = new UsuarioDTO();
        private CorpoDirigenteAssociacaoDTO dirigenteDto = new CorpoDirigenteAssociacaoDTO();

        public FrmCadMembro()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfSenha.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Informe a senha e a confirmação de senha!");
                return;
            }
            if (txtConfSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("Senha e a confirmação de senha devem ser iguais!");
                return;
            }

            dirigenteDto.Nome = txtNome.Text;
            dirigenteDto.Apelido = txtApelido.Text;
            dirigenteDto.Telefone = txtFone.Text;
            dirigenteDto.IdCargo = int.Parse(cboNivel.Text.Substring(0, 1));

            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.ConfirmaSenha = txtConfSenha.Text;

            try
            {

                await FrmMain._ServiceSegurancaIdentity.CriarUsuario(usuario, dirigenteDto);
            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
