using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entity;
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
        public FrmCrudNecessidade()
        {
            InitializeComponent();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            NecessidadesDTO necessidadesDTO = new NecessidadesDTO();
            necessidadesDTO.DescricaoNecessidadeEspecial = txtDescricao.Text;
            necessidadesDTO.Permanete = cboPermanente.Text;
            necessidadesDTO.NecessitaRemedioControlado = cboRemedio.Text;

            try {
                await FrmMain._ServicoNecessidadeEspecial.CadastrarNecessidade(necessidadesDTO);
            }
            catch (ExcecoesCustomizadas ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
