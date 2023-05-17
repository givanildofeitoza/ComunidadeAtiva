using ComunidadeAtiva.Dominio.Entidades;
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
        private ImoradorService _Morador;
        private readonly IbeneficioSocialService _beneficioSocial;
        private readonly InecessidadeEspecialService _necessidadeEspecial;
        private readonly IruaService _ruaService;
        private readonly ICapturarNotificacao _notificacao;
        private Morador Morador;

        public _FrmCrudMorador(ImoradorService Morador, 
            IbeneficioSocialService beneficioSocial, 
            InecessidadeEspecialService necessidadeEspecial,
            ICapturarNotificacao notificacao,
            IruaService ruaService, FileDbContext db)
        {
            InitializeComponent();
            _Morador = Morador;
            _beneficioSocial = beneficioSocial;
            _necessidadeEspecial = necessidadeEspecial;
            _ruaService = ruaService;
            _db = db;
            _notificacao = notificacao;
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
            Morador = await _Morador.ObterMoradorRelacionalRuaId(Id);
            if (Morador == null)
                return;

            txtNome.Text = Morador?.Nome;
            txtId.Text = Morador?.id.ToString();
            txtData.Value = Morador == null ? DateTime.Now : Morador.Nascimento;
            txtCpf.Text = Morador?.Cpf;
            txtRg.Text = Morador?.Rg;
            txtNumero.Text = Morador?.NumeroCasa;
            cboSituacao.Text = Morador?.Situacao;
            cboEstadoCivil.Text = Morador?.EstadoCivil;
            txtNumero.Text = Morador?.NumeroCasa;

            txtDescRua.Text = $" {Morador.rua.Nome1}({Morador.rua.Nome2}). " +
                            $" \r\n Calçada: {Morador.rua.Calcada} " +
                            $" \r\n Água: {Morador.rua.Agua} " +
                            $" \r\n Coleta de Lixo:{Morador.rua.ColetaLixo} " +
                            $" \r\n Energia: {Morador.rua.Energia} " +
                            $" \r\n Saneamento: {Morador.rua.Saneamento} " +
                            $" \r\n Agente de saúde: {Morador.rua.AgenteSaudeResponsval}";

            CarregarDadosAxuliaresMorador();
        }
        private async void CarregarDadosAxuliaresMorador()
        {
            Morador = await _Morador.ObterMoradorRelacionalRuaId(Morador.id);
            var beneficio = await _beneficioSocial.ObterTodos(50, 0);
            ListBoxBeneficio.Items.Clear();
            foreach (var b in Morador.moradorBeneficioSocial)
                ListBoxBeneficio.Items.Add(beneficio.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial + "- R$ " + b.Valor.ToString("0.00"));

            var necessidade = await _necessidadeEspecial.ObterTodos(50, 0);
            ListBoxNecessidade.Items.Clear();
            foreach (var n in Morador.necessidadeEspecial)
            {
                var detNecessidade = necessidade.Where(x => x.id == n.NecessidadeId).FirstOrDefault();
                ListBoxNecessidade.Items.Add("Remédio:" + detNecessidade.NecessitaRemedioControlado + "  " + detNecessidade.DescricaoNecessidadeEspecial);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            _FrmCrudRua Frua = new _FrmCrudRua(_notificacao,_ruaService);
            Frua.ShowDialog();
            var dadosRua = await _ruaService.ObterPorId(Frua.Id);

            txtDescRua.Text = $" {dadosRua.Nome1}({dadosRua.Nome2}). " +
                            $" \r\n Calçada: {dadosRua.Calcada} " +
                            $" \r\n Água: {dadosRua.Agua} " +
                            $" \r\n Coleta de Lixo:{dadosRua.ColetaLixo} " +
                            $" \r\n Energia: {dadosRua.Energia} " +
                            $" \r\n Saneamento: {dadosRua.Saneamento} " +
                            $" \r\n Agente de saúde: {dadosRua.AgenteSaudeResponsval}";

            txtIdRua.Text = Frua.Id.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _FrmCrudNecessidades Fnecessidade = new _FrmCrudNecessidades(Morador);
            Fnecessidade.ShowDialog();
            CarregarDadosAxuliaresMorador();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _FrmCrudBeneficios Fbeneficio = new _FrmCrudBeneficios(Morador.id);
            Fbeneficio.ShowDialog();
            CarregarDadosAxuliaresMorador();
        }
    }
}
