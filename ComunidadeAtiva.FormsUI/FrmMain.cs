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

namespace ComunidadeAtiva.FormsUI
{
    public partial class FrmMain : Form
    {
        public static string UsuarioLogado = "";
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
        public static ICorpoDirigenteAssociacao _CorpoDirigenteAssociacao;
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
            ICorpoDirigenteAssociacao CorpoDirigenteAssociacao
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

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            lblOperadorLogado.Text = UsuarioLogado;

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
                        _FrmCrudMorador Fmorador = new _FrmCrudMorador(_ServicoMorador, _beneficioSocial, _necessidadeEspecial, _notificacao, _ruaService, _db, AcaoControleCadastro.ALTERAR);
                        flowLayoutPanel1.Controls.Clear();
                        var listMoradores = await _ServicoMorador.ObterTodosRelacionalMorador(10, 0);
                        CustomListItem[] listItem = new CustomListItem[listMoradores.Count()];
                        int i = 0;
                        foreach (var item in listMoradores)
                        {
                            listItem[i] = new CustomListItem(Fmorador);
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
                        var listBeneficios = await _ServicoBeneficioSocial.ObterBeneficioTodos(50, 0);
                        CustomListItem[] listItem = new CustomListItem[listBeneficios.Count()];
                        int i = 0;
                        foreach (var item in listBeneficios)
                        {
                            listItem[i] = new CustomListItem(Fmorador);
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
                        CustomListItem[] listItem = new CustomListItem[listNecessidades.Count()];
                        int i = 0;
                        foreach (var item in listNecessidades)
                        {
                            listItem[i] = new CustomListItem(frmCrudNecessidade);
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOpcaoAtiva.Text = "NECESSIDADES ESPECIAIS";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _FrmCrudRua Frua = new _FrmCrudRua(_ruaService);
            Frua.ShowDialog();
        }
    }
}