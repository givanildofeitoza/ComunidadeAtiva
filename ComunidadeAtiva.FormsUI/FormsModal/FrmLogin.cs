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
                }
            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
