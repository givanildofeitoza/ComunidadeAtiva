using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.Classes;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class _FrmCrudMorador : ClasseFormPadrao
    {

        private readonly FileDbContext _db;
        private readonly Imorador _Morador;
        private readonly IbeneficioSocial _beneficioSocial;
        private readonly InecessidadeEspecial _necessidadeEspecial;
        private readonly Irua _ruaService;

        public _FrmCrudMorador(Imorador Morador, IbeneficioSocial beneficioSocial, InecessidadeEspecial necessidadeEspecial, Irua ruaService, FileDbContext db)
        {
            InitializeComponent();
            _Morador = Morador;
            _beneficioSocial = beneficioSocial;
            _necessidadeEspecial = necessidadeEspecial;
            _ruaService = ruaService;
            _db = db;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Morador m = new Morador();
            m.Nome = txtNome.Text;
            m.Cpf = txtCpf.Text;
            m.Rg = txtRg.Text;
            m.Situacao = cboSituacao.Text;
            m.EstadoCivil = cboEstadoCivil.Text;
            m.RuaId = int.Parse(txtIdRua.Text);
            m.Nascimento = Convert.ToDateTime(txtData.Text);
            m.NumeroCasa = txtNumero.Text;
            _Morador.Cadastrar(m);
            MessageBox.Show("Cadastrado com Sucesso!");
        }
        private async void _FrmCrudMorador_Load(object sender, EventArgs e)
        {
            var m = await _Morador.ObterMoradorRelacionalId(Id);
            if (m == null)
                return;

            txtNome.Text = m?.Nome;
            txtId.Text = m?.id.ToString();
            txtData.Value = m == null ? DateTime.Now : m.Nascimento;
            txtCpf.Text = m?.Cpf;
            txtRg.Text = m?.Rg;
            txtNumero.Text = m?.NumeroCasa;
            cboSituacao.Text = m?.Situacao;
            cboEstadoCivil.Text = m?.EstadoCivil;
            txtNumero.Text = m?.NumeroCasa;

            txtDescRua.Text = $" {m.rua.Nome1}({m.rua.Nome2}). " +
                            $" \r\n Calçada: {m.rua.Calcada} " +
                            $" \r\n Água: {m.rua.Agua} " +
                            $" \r\n Coleta de Lixo:{m.rua.ColetaLixo} " +
                            $" \r\n Energia: {m.rua.Energia} " +
                            $" \r\n Saneamento: {m.rua.Saneamento} " +
                            $" \r\n Agente de saúde: {m.rua.AgenteSaudeResponsval}";

            var beneficio = await _beneficioSocial.ObterTodos(50, 0);
            ListBoxBeneficio.Items.Clear();
            foreach (var b in m.moradorBeneficioSocial)
                ListBoxBeneficio.Items.Add(beneficio.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial + "- R$ " + b.Valor.ToString("0.00"));

            var necessidade = await _necessidadeEspecial.ObterTodos(50, 0);
            ListBoxNecessidade.Items.Clear();
            foreach (var n in m.necessidadeEspecial)
            {
                var detNecessidade = necessidade.Where(x => x.id == n.NecessidadeId).FirstOrDefault();
                ListBoxNecessidade.Items.Add("Remédio:" + detNecessidade.NecessitaRemedioControlado + "  " + detNecessidade.DescricaoNecessidadeEspecial);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _FrmCrudRua Frua = new _FrmCrudRua(_ruaService);
            Frua.ShowDialog();
            txtIdRua.Text = Frua.Id.ToString();
        }
    }
}
