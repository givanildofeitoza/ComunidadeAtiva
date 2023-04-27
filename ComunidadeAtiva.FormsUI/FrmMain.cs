using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.FormsModal;
using System.Windows.Forms;

namespace ComunidadeAtiva.FormsUI
{
    public partial class FrmMain : Form
    {
        private readonly FileDbContext _db;
        private readonly Imorador _Morador;
        private readonly Irua _Rua;
        public delegate void AbrirModalForm(Form frmModal, int id);

        public FrmMain(
            Imorador Morador,
            Irua Rua,
            FileDbContext db
            )
        {
            InitializeComponent();
            _Morador = Morador;
            _Rua = Rua;
            _db = db;

        }
        public void AbrirModal(Form frmModal, int id)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_Morador.ObterMoradorId(int.Parse(textBox1.Text)).Nome);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _FrmCrudMorador Fmorador = new _FrmCrudMorador(_Morador, _db);
            flowLayoutPanel1.Controls.Clear();
            var listMoradores = _Morador.ObterTodosMorador(10, 0);
            CustomListItem[] listItem = new CustomListItem[listMoradores.Count()];
            int i = 0;
            foreach (var item in listMoradores)
            {
                listItem[i] = new CustomListItem(Fmorador);
                listItem[i].Title = item.Nome;
                listItem[i].Texto01 = "Codigo " + item.id.ToString();
                listItem[i].Texto02 = $"{_Rua.ObterRuaId(item.IdRua).Nome1.ToString()} ({_Rua.ObterRuaId(item.IdRua).Nome2.ToString()})";
                listItem[i].Texto03 = item.Situacao;
                listItem[i].Texto04 = "Nascimento: " + item.Nascimento.ToString("dd/mm/yyyy");
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
            _FrmCrudMorador Fmorador = new _FrmCrudMorador(_Morador, _db);
            Fmorador.ShowDialog();
        }
    }
}