using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Dominio.Exceptions;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.Classes;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using System.Data;

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class _FrmCrudMorador : ClasseFormPadrao
    {
        private readonly FileDbContext _db;
        private readonly IServicoMorador _MoradorServico;
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
            m.RuaId = int.Parse(txtIdRua.Text==""? "0" : txtIdRua.Text);
            m.Nascimento = Convert.ToDateTime(txtData.Text);
            m.NumeroCasa = txtNumero.Text;

            if (_AcaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                try
                {
                    await _MoradorServico.CadastrarMorador(m);
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                catch (ExcecoesCustomizadas ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    m.id = txtId.Text;
                    await _MoradorServico.AlterarMorador(m);
                    MessageBox.Show("Alterado com Sucesso!");
                }
                catch (ExcecoesCustomizadas ex)
                {
                    MessageBox.Show(ex.Message);
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

            txtDescRua.Items.Add($"{Morador.rua.Nome1}({Morador.rua.Nome2}). ");
            txtDescRua.Items.Add($"Calçada: {Morador.rua.Calcada} ");
            txtDescRua.Items.Add($"Água: {Morador.rua.Agua} ");
            txtDescRua.Items.Add($"Coleta de Lixo:{Morador.rua.ColetaLixo} ");
            txtDescRua.Items.Add($"Energia: {Morador.rua.Energia} ");
            txtDescRua.Items.Add($"Saneamento: {Morador.rua.Saneamento} ");
            txtDescRua.Items.Add($"Agente de saúde: {Morador.rua.AgenteSaudeResponsval}");
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

            txtDescRua.Items.Add($"{dadosRua.Nome1}({dadosRua.Nome2}). ");
            txtDescRua.Items.Add($"Calçada: {dadosRua.Calcada} ");
            txtDescRua.Items.Add($"Água: {dadosRua.Agua} ");
            txtDescRua.Items.Add($"Coleta de Lixo:{dadosRua.ColetaLixo} ");
            txtDescRua.Items.Add($"Energia: {dadosRua.Energia} ");
            txtDescRua.Items.Add($"Saneamento: {dadosRua.Saneamento} ");
            txtDescRua.Items.Add($"Agente de saúde: {dadosRua.AgenteSaudeResponsval}");

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

        private void _FrmCrudMorador_Shown(object sender, EventArgs e)
        {
            if (_AcaoControleCadastro == AcaoControleCadastro.CADASRTRAR)
            {
                pnlBeneficiosNecessidade.Visible = false;
                pnlId.Visible = false;
            }
            else
            {
                pnlBeneficiosNecessidade.Visible = true;
                pnlId.Visible = true;
            }


        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            _FrmCrudBeneficios frmBeneficio = new _FrmCrudBeneficios(int.Parse(txtId.Text));
            frmBeneficio.ShowDialog();
            CarregarDadosAxuliaresMorador();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            _FrmCrudNecessidades frmCrudNecessidades = new _FrmCrudNecessidades(Morador);
            frmCrudNecessidades.ShowDialog();
            CarregarDadosAxuliaresMorador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RGprint rGprint = new RGprint(true, 55);
            rGprint.impCabecalho("FICHA DE CADASTRO DE MORADOR", 15, FontStyle.Bold, 16, true);
            rGprint.impCabecalho("", 1, FontStyle.Regular, 16, true);
            rGprint.impCabecalho("", 1, FontStyle.Regular, 16, true);
            rGprint.impCabecalho("DATA IMPRESSÃO:" + DateTime.Now.ToString("dd/mm/yyyy"), 1, FontStyle.Bold, 16, true);
            rGprint.impCabecalho("===========================================================================================================================================", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("Nome: " + txtNome.Text, 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("RG: " + txtRg.Text + "          CPF: " + txtCpf.Text, 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("Situação: " + cboSituacao.Text + "        Estado Civil: " + cboEstadoCivil.Text, 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("Nascimento: " + txtData.Text, 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("DADOS DA RUA", 1, FontStyle.Bold, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
          
            var ruaLinhaImp = 1;
            foreach (var r in txtDescRua.Items)
            {                
                rGprint.impLinha(r.ToString(), 1, FontStyle.Regular, 16, true);
               if(ruaLinhaImp==1)
                rGprint.impLinha("N° Casa: " + txtNumero.Text, 20, FontStyle.Regular, 16, false);

                ruaLinhaImp += 1;
            }
           
            rGprint.impLinha("", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("NECESSIDADES ESPECIAIS", 1, FontStyle.Bold, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
            foreach (var n in ListBoxNecessidade.Items)
               rGprint.impLinha(n.ToString(), 1, FontStyle.Regular, 16, true);

            
            rGprint.impLinha("", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
            rGprint.impLinha("BENEFÍCIO SOCIAL", 1, FontStyle.Bold, 16, true);
            rGprint.impLinha("-------------------------------------------------------------------------------------------------------------------------------------------------", 1, FontStyle.Regular, 16, true);
            foreach (var b in ListBoxBeneficio.Items)
               rGprint.impLinha(b.ToString(), 1, FontStyle.Regular, 16, true);

            
            rGprint.Imprimir();


        }
    }
}
