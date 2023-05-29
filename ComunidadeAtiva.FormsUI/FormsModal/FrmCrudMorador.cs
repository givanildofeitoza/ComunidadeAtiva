using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
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
        private readonly IServicoMorador  _MoradorServico;
        private readonly IbeneficioSocialRepositorio _beneficioSocial;
        private readonly InecessidadeEspecialRepositorio _necessidadeEspecial;
        private readonly IServicoRua _ruaService;
        private readonly ICapturarNotificacao _notificacao;
        private MoradorDTO Morador;
        private AcaoControleCadastro _AcaoControleCadastro;


        public _FrmCrudMorador(IServicoMorador MoradorServico, 
            IbeneficioSocialRepositorio beneficioSocial, 
            InecessidadeEspecialRepositorio necessidadeEspecial,
            ICapturarNotificacao notificacao,
            IServicoRua ruaService, FileDbContext db,
            AcaoControleCadastro AcaoControleCadastro)
        {
            InitializeComponent();
            _MoradorServico = MoradorServico;
            _beneficioSocial = beneficioSocial;
            _necessidadeEspecial = necessidadeEspecial;
            _ruaService = ruaService;
            _db = db;
            _notificacao = notificacao;
            _AcaoControleCadastro = AcaoControleCadastro;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            MoradorDTO m = new MoradorDTO();         
            m.Nome = txtNome.Text;
            m.Cpf = txtCpf.Text;
            m.Rg = txtRg.Text;
            m.Situacao = cboSituacao.Text;
            m.EstadoCivil = cboEstadoCivil.Text;
            m.RuaId = int.Parse(txtIdRua.Text);
            m.Nascimento = Convert.ToDateTime(txtData.Text);
            m.NumeroCasa = txtNumero.Text;

            if (_AcaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                try
                {
                    await _MoradorServico.CadastrarMorador(m);
                }
                catch
                {
                    EmitirExcecoes.EmitirExcecao(_notificacao);
                }
                finally {
                    MessageBox.Show("Cadastrado com Sucesso!");
                }                
                
            }
            else
            {
                try
                {
                    m.id = txtId.Text;
                    _MoradorServico.AlterarMorador(m);
                }
                catch
                {
                    EmitirExcecoes.EmitirExcecao(_notificacao);
                }
                finally
                {
                    MessageBox.Show("Alterado com Sucesso!");
                }
                
                
            }
        }
        private async void _FrmCrudMorador_Load(object sender, EventArgs e)
        {
            Morador = await _MoradorServico.ObterMoradorRelacionalRuaId(Id);
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
            Morador = await _MoradorServico.ObterMoradorRelacionalRuaId(int.Parse(Morador.id));
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
            _FrmCrudRua Frua = new _FrmCrudRua(_ruaService);
            Frua.ShowDialog();
            var dadosRua = await _ruaService.ObterRuaPorId(Frua.Id);

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
            _FrmCrudBeneficios Fbeneficio = new _FrmCrudBeneficios(int.Parse(Morador.id));
            Fbeneficio.ShowDialog();
            CarregarDadosAxuliaresMorador();
        }
    }
}
