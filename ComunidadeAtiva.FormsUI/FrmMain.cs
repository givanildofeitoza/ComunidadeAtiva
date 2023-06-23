using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.FormsModal;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.Aplicacao.CasosDeUso;
using Microsoft.AspNetCore.Identity;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.ObjetoValor;
using System.Security.Cryptography;
using ComunidadeAtiva.Dominio.ObjetoValor;

namespace ComunidadeAtiva.FormsUI
{
    public partial class FrmMain : Form
    {
        public static string razao = "";
        public static string cnpj = "";
        public static string endereco = "";


        public static CorpoDirigenteAssociacaoDTO usuarioLogado = new CorpoDirigenteAssociacaoDTO();
        private readonly FileDbContext _db;
        public static IServicoMorador _ServicoMorador;
        public static IServicoBeneficoSocialMorador _ServicoBeneficoSocialMorador;
        public static IbeneficioSocialRepositorio _beneficioSocial;
        public static InecessidadeEspecialRepositorio _necessidadeEspecial;
        public static IServicoRua _ruaService;
        public static ICapturarNotificacao _notificacao;
        public static IMapper _mapper;
        public static IServicoNecessidadeMorador _ServicoNecessidadeMorador;
        public static IServicoBeneficioSocial _ServicoBeneficioSocial;
        public static IServicoNecessidadeEspecial _ServicoNecessidadeEspecial;
        public static IServiceSegurancaIdentity _ServiceSegurancaIdentity;
        public static IServicoCorpoDirigenteAssociacao _CorpoDirigenteAssociacao;
        public static IServicoAssociacao _ServicoAssociacao;
        public FrmMain(
            FileDbContext db,
            IServicoMorador ServicoMorador,
            IServicoBeneficoSocialMorador ServicoBeneficoSocialMorador,
            IbeneficioSocialRepositorio beneficioSocial,
            InecessidadeEspecialRepositorio necessidadeEspecial,
            IServicoRua ruaService,
            ICapturarNotificacao notificacao,
            IMapper mapper,
            IServicoNecessidadeMorador ServicoNecessidadeMorador,
            IServicoBeneficioSocial ServicoBeneficioSocial,
            IServicoNecessidadeEspecial ServicoNecessidadeEspecial,
            IServiceSegurancaIdentity ServiceSegurancaIdentity,
            IServicoCorpoDirigenteAssociacao CorpoDirigenteAssociacao,
            IServicoAssociacao ServicoAssociacao
            )
        {
            InitializeComponent();
            _ServicoMorador = ServicoMorador;
            _ServicoBeneficoSocialMorador = ServicoBeneficoSocialMorador;
            _beneficioSocial = beneficioSocial;
            _necessidadeEspecial = necessidadeEspecial;
            _ruaService = ruaService;
            _db = db;
            _notificacao = notificacao;
            _mapper = mapper;
            _ServicoNecessidadeMorador = ServicoNecessidadeMorador;
            _ServicoBeneficioSocial = ServicoBeneficioSocial;
            _ServicoNecessidadeEspecial = ServicoNecessidadeEspecial;
            _ServiceSegurancaIdentity = ServiceSegurancaIdentity;
            _CorpoDirigenteAssociacao = CorpoDirigenteAssociacao;
            _ServicoAssociacao = ServicoAssociacao;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button8_Click(object sender, EventArgs e)
        {

            switch (lblOpcaoAtiva.Text)
            {
                case "MORADORES":
                    {
                        BuscaObjectDTO buscaMorador = new BuscaObjectDTO("", "", "", "", "");
                        buscaMorador.TextoBusca = txtBusca.Text;

                        _FrmCrudMorador Fmorador = new _FrmCrudMorador(_ServicoMorador, _beneficioSocial, _necessidadeEspecial, _notificacao, _ruaService, _db, AcaoControleCadastro.ALTERAR);
                        flowLayoutPanel1.Controls.Clear();
                        var listMoradores = await _ServicoMorador.ObterTodosRelacionalMorador(100, 0, buscaMorador);
                        CustomListItem[] listItem = new CustomListItem[listMoradores.Count()];
                        int i = 0;
                        foreach (var item in listMoradores)
                        {
                            listItem[i] = new CustomListItem(Fmorador);
                            listItem[i].BoundedContext = "MORADORES";
                            listItem[i].Title = item.Nome;
                            listItem[i].Texto01 = item.id.ToString();
                            listItem[i].Texto02 = $"{item.rua.Nome1} - {item.rua.Nome2}, N° {item.NumeroCasa}";
                            listItem[i].Texto03 = item.Situacao;
                            listItem[i].Texto04 = $"{(int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(item.Nascimento.ToString("yyyy"))).ToString()} Anos";

                            flowLayoutPanel1.Controls.Add(listItem[i]);
                            i++;
                        }

                        break;
                    }
                case "PROGRAMAS SOCIAIS":
                    {

                        FormCrudBeneficioSocial Fmorador = new FormCrudBeneficioSocial(AcaoControleCadastro.ALTERAR);
                        flowLayoutPanel1.Controls.Clear();
                        var listBeneficios = await _ServicoBeneficioSocial.ObterBeneficioTodos(100, 0);

                        if (!string.IsNullOrEmpty(txtBusca.Text))
                            listBeneficios = listBeneficios.Where(x => x.NomeBeneficioSocial.ToUpper().Contains(txtBusca.Text.ToUpper())).ToList();

                        CustomListItem[] listItem = new CustomListItem[listBeneficios.Count()];
                        int i = 0;
                        foreach (var item in listBeneficios)
                        {
                            listItem[i] = new CustomListItem(Fmorador);
                            listItem[i].BoundedContext = "PROGRAMAS SOCIAIS";
                            listItem[i].Title = item.NomeBeneficioSocial;
                            listItem[i].Texto01 = item.Id.ToString();
                            listItem[i].Texto02 = item.DescricaoBeneficioSocial;
                            listItem[i].Texto03 = "Ativo: " + item.Ativo;
                            listItem[i].Texto04 = "";

                            flowLayoutPanel1.Controls.Add(listItem[i]);
                            i++;
                        }
                        break;
                    }
                case "NECESSIDADES ESPECIAIS":
                    {

                        FrmCrudNecessidade frmCrudNecessidade = new FrmCrudNecessidade(AcaoControleCadastro.ALTERAR);
                        _FrmCrudMorador Fmorador = new _FrmCrudMorador(_ServicoMorador, _beneficioSocial, _necessidadeEspecial, _notificacao, _ruaService, _db, AcaoControleCadastro.ALTERAR);
                        flowLayoutPanel1.Controls.Clear();
                        var listNecessidades = await _ServicoNecessidadeEspecial.ObterNecessidadeTodos(50, 0);

                        if (!string.IsNullOrEmpty(txtBusca.Text))
                            listNecessidades = listNecessidades.Where(x => x.DescricaoNecessidadeEspecial.ToUpper().Contains(txtBusca.Text.ToUpper()));

                        CustomListItem[] listItem = new CustomListItem[listNecessidades.Count()];
                        int i = 0;
                        foreach (var item in listNecessidades)
                        {
                            
                            listItem[i] = new CustomListItem(frmCrudNecessidade);
                            listItem[i].BoundedContext = "NECESSIDADES ESPECIAIS";
                            listItem[i].Title = item.DescricaoNecessidadeEspecial;
                            listItem[i].Texto01 = item.Id.ToString();
                            listItem[i].Texto02 = "Permanente: " + item.Permanete;
                            listItem[i].Texto03 = "Necessita Remédio: " + item.NecessitaRemedioControlado;
                            listItem[i].Texto04 = "";

                            flowLayoutPanel1.Controls.Add(listItem[i]);
                            i++;
                        }

                        break;
                    }

                default:
                    {
                        break;
                    }

            }


        }
        private void btnMorador_Click(object sender, EventArgs e)
        {
            lblOpcaoAtiva.Text = "MORADORES";
            flowLayoutPanel1.Controls.Clear();
        }
        private void imgAlter_Click(object sender, EventArgs e)
        {
            switch (lblOpcaoAtiva.Text)
            {
                case "MORADORES":
                    {
                        _FrmCrudMorador Fmorador = new _FrmCrudMorador(_ServicoMorador, _beneficioSocial, _necessidadeEspecial, _notificacao, _ruaService, _db, AcaoControleCadastro.CADASRTRAR);
                        Fmorador.ShowDialog();
                        break;
                    }
                case "NECESSIDADES ESPECIAIS":
                    {
                        FrmCrudNecessidade frmCrudNecessidade = new FrmCrudNecessidade(AcaoControleCadastro.CADASRTRAR);
                        frmCrudNecessidade.ShowDialog();
                        break;
                    }
                case "PROGRAMAS SOCIAIS":
                    {
                        FormCrudBeneficioSocial formCrudBeneficioSocial = new FormCrudBeneficioSocial(AcaoControleCadastro.CADASRTRAR);
                        formCrudBeneficioSocial.ShowDialog();
                        break;
                    }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmImprimir frmImprimir = new FrmImprimir();
            frmImprimir.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOpcaoAtiva.Text = "PROGRAMAS SOCIAIS";
            flowLayoutPanel1.Controls.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOpcaoAtiva.Text = "NECESSIDADES ESPECIAIS";
            flowLayoutPanel1.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _FrmCrudRua Frua = new _FrmCrudRua(_ruaService);
            Frua.ShowDialog();
        }

        private async void FrmMain_Shown(object sender, EventArgs e)
        {
            usuarioLogado = await _CorpoDirigenteAssociacao.ObterDirigenteRelacional(usuarioLogado.UsuarioId);
            lblOperadorLogado.Text = usuarioLogado == null ? "USUÁRIO ANÔNIMO" : usuarioLogado.Nome.ToUpper();


            IEnumerable<AssociacaoDTO> associacao = await _ServicoAssociacao.ObterAssociacaoTodos(1, 0);
            if (associacao.Count() > 0)
            {

                razao = associacao.FirstOrDefault().NomeFantasia;
                cnpj = "CNPJ: " + associacao.FirstOrDefault().Cnpj + " " + "Fone: " + associacao.FirstOrDefault().Telefone;
                endereco = associacao.FirstOrDefault().Endereco + " " + associacao.FirstOrDefault().Cidade + "-" + associacao.FirstOrDefault().Estado;

                lblRazao.Text = razao;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDadosAssociacao frmDadosAssociacao = new FrmDadosAssociacao();
            frmDadosAssociacao.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmCadMembro frmCadMembro = new FrmCadMembro();
            frmCadMembro.ShowDialog();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
        }
    }
}