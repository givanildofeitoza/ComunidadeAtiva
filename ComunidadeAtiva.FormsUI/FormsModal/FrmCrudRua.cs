using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class _FrmCrudRua : ClasseFormPadrao
    {
        private Irua _ruaService;

        private AcaoControleCadastro opcao;

        private Rua RuaMovimento;
        public _FrmCrudRua(Irua ruaService)
        {
            _ruaService = ruaService;
            InitializeComponent();
        }
        private async void CarregarGrid()
        {
            var list = await _ruaService.ObterTodos(50, 0);
            var tabela = list.Select(r => new
            {
                id = r.id,
                Nome1 = r.Nome1,
                Nome2 = r.Nome2,
                Calcada = r.Calcada,
                Saneamento = r.Saneamento,
                Energia = r.Energia,
                Agua = r.Agua,
                ColetaLixo = r.ColetaLixo,
                AgenteSaude = r.AgenteSaudeResponsval

            }).ToList();
            gridRua.DataSource = tabela;
        }
        private async void MovimentarMorador(AcaoControleCadastro acao)
        {
            if (acao == AcaoControleCadastro.CADASRTRAR)
            {
                Rua r = new Rua();
                r.Nome1 = txtNome.Text;
                r.Nome2 = txtNomeAntigo.Text;
                r.Energia = cboEnergia.Text;
                r.Calcada = cboCalcada.Text;
                r.ColetaLixo = cboLixo.Text;
                r.Agua = cboAgua.Text;
                r.Saneamento = cboSaneamento.Text;
                r.Cep = txtCep.Text;
                r.AgenteSaudeResponsval = txtAgenteSaude.Text;
                await _ruaService.Cadastrar(r);
                MessageBox.Show("Cadastrado com sucesso !");
                CarregarGrid();
                pnlCadRua.Visible = false;

            }
            else
            {
                RuaMovimento.Nome1 = txtNome.Text;
                RuaMovimento.Nome2 = txtNomeAntigo.Text;
                RuaMovimento.Energia = cboEnergia.Text;
                RuaMovimento.Calcada = cboCalcada.Text;
                RuaMovimento.ColetaLixo = cboLixo.Text;
                RuaMovimento.Agua = cboAgua.Text;
                RuaMovimento.Saneamento = cboSaneamento.Text;
                RuaMovimento.Cep = txtCep.Text;
                RuaMovimento.AgenteSaudeResponsval = txtAgenteSaude.Text;
                await _ruaService.Alterar(RuaMovimento);
                MessageBox.Show("Alterado com sucesso !");
                CarregarGrid();
                pnlCadRua.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovimentarMorador(opcao);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            RuaMovimento = await _ruaService.ObterPorId(Id);
            txtNome.Text = RuaMovimento.Nome1;
            txtNomeAntigo.Text = RuaMovimento.Nome2;
            cboEnergia.Text = RuaMovimento.Energia;
            cboCalcada.Text = RuaMovimento.Calcada;
            cboLixo.Text = RuaMovimento.ColetaLixo;
            cboAgua.Text = RuaMovimento.Agua;
            cboSaneamento.Text = RuaMovimento.Saneamento;
            txtCep.Text = RuaMovimento.Cep;
            txtAgenteSaude.Text = RuaMovimento.AgenteSaudeResponsval;

            opcao = AcaoControleCadastro.ALTERAR;
            pnlCadRua.Visible = true;
        }

        private void gridRua_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Id = int.Parse(gridRua.Rows[e.RowIndex].Cells[0].Value.ToString() == null ? "0" : gridRua.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opcao = AcaoControleCadastro.CADASRTRAR;
            pnlCadRua.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlCadRua.Visible = false;
        }

        private async void FrmCrudRua_Shown(object sender, EventArgs e)
        {
            CarregarGrid();
        }

    }
}
