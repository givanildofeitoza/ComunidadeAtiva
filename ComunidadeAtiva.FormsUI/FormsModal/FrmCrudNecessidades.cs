using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class _FrmCrudNecessidades : ClasseFormPadrao
    {
        private Morador _MoradorAtivo;

        public _FrmCrudNecessidades(Morador MoradorAtivo)
        {
            InitializeComponent();
            _MoradorAtivo = MoradorAtivo;

        }

        private async Task AtualizarGrid()
        {
            _MoradorAtivo = await FrmMain._Morador.ObterMoradorRelacionalRuaId(_MoradorAtivo.id);
            var ListNecessidadesEspeciais = await FrmMain._necessidadeEspecial.ObterTodos(50, 0);
            List<NecessidadesMoradorDTO> TabelaNecessidadeMorador = new List<NecessidadesMoradorDTO>();
            foreach (var n in _MoradorAtivo.necessidadeEspecial)
            {
                TabelaNecessidadeMorador.Add(
                new NecessidadesMoradorDTO
                {
                    Id = n.id,
                    DescricaoNecessidade = ListNecessidadesEspeciais.Where(x => x.id == n.NecessidadeId).FirstOrDefault().DescricaoNecessidadeEspecial
                });
            }
            gridNcessidade.DataSource = TabelaNecessidadeMorador.Select(x => new { Id = x.Id, Descricao = x.DescricaoNecessidade }).ToList();
        }

        private async void _FrmCrudNecessidades_Load(object sender, EventArgs e)
        {
            await AtualizarGrid();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var necessidades = await FrmMain._necessidadeEspecial.ObterTodos(50, 0);
            cbonecessidade.Items.Clear();
            foreach (var n in necessidades)
            {
                cbonecessidade.Items.Add($"{n.id.ToString().PadLeft(4, '0')}-{n.DescricaoNecessidadeEspecial}");
            }
            pnlListaNecessidade.Visible = true;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {

            if (_MoradorAtivo.necessidadeEspecial.Where(x => x.NecessidadeId == int.Parse(cbonecessidade.Text.Substring(0, 4))).Count() > 0)
            {
                MessageBox.Show("Morador Já tem essa necessidade informada!");
                return;
            }

            MoradorNecessidadeEspecial n = new MoradorNecessidadeEspecial();
            n.MoradorId = _MoradorAtivo.id;
            n.NecessidadeId = int.Parse(cbonecessidade.Text.Substring(0, 4));

            await FrmMain._ImoradorNecessidadeEspecial.Cadastrar(n);
            await AtualizarGrid();
            pnlListaNecessidade.Visible = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Excluir Informação?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            var n = await FrmMain._ImoradorNecessidadeEspecial.ObterPorId(Id);
            if (n == null)
                return;

            await FrmMain._ImoradorNecessidadeEspecial.Deletar(n);
            await AtualizarGrid();
        }

        private void gridNcessidade_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(gridNcessidade.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlListaNecessidade.Visible = false;
        }
    }
}
