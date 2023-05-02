using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.FormsModal;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ComunidadeAtiva.FormsUI
{
    public partial class FrmMain : Form
    {
        private readonly FileDbContext _db;
        private readonly Imorador _Morador;
        private readonly IbeneficioSocial _beneficioSocial;
        private readonly InecessidadeEspecial _necessidadeEspecial;
        private readonly Irua _ruaService;


        public FrmMain(
            Imorador Morador,
            IbeneficioSocial beneficioSocial,
            InecessidadeEspecial necessidadeEspecial,
            Irua ruaService,
            FileDbContext db
            )
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
            //MessageBox.Show(_Morador.ObterMoradorId(int.Parse(textBox1.Text)).Nome);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            _FrmCrudMorador Fmorador = new _FrmCrudMorador(_Morador, _beneficioSocial, _necessidadeEspecial, _ruaService, _db);
            flowLayoutPanel1.Controls.Clear();
            var listMoradores = await _Morador.ObterTodosRelacionalMorador(10, 0);
            CustomListItem[] listItem = new CustomListItem[listMoradores.Count()];
            int i = 0;
            foreach (var item in listMoradores)
            {
                listItem[i]         = new CustomListItem(Fmorador);
                listItem[i].Title   = item.Nome;
                listItem[i].Texto01 = item.id.ToString();
                listItem[i].Texto02 = $"{item.rua.Nome1} - {item.rua.Nome2}, N° {item.NumeroCasa}";
                listItem[i].Texto03 = item.Situacao;
                listItem[i].Texto04 = $"{(int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(item.Nascimento.ToString("yyyy"))).ToString()} Anos";
                
                flowLayoutPanel1.Controls.Add(listItem[i]);
                i++;
            }
        }
        private void btnMorador_Click(object sender, EventArgs e)
        {
            lblOpcaoAtiva.Text = "MORADORES";
        }
        private void imgAlter_Click(object sender, EventArgs e)
        {
            _FrmCrudMorador Fmorador = new _FrmCrudMorador(_Morador, _beneficioSocial, _necessidadeEspecial,_ruaService, _db);
            Fmorador.ShowDialog();
        }
    }
}