using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.FormsUI.FormsModal;

namespace ComunidadeAtiva.FormsUI
{
    public partial class FrmMain : Form
    {
        private readonly FileDbContext _db;
        private readonly Imorador _Morador;
        public delegate void AbrirModalForm(Form frmModal, int id);

        public FrmMain(Imorador Morador, FileDbContext db)
        {

            InitializeComponent();
            _Morador = Morador;
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
            _FrmCrudMorador Fmorador = new _FrmCrudMorador();
            _FrmCrudSocio frmCrudSocio = new _FrmCrudSocio();

            CustomListItem[] listItem = new CustomListItem[20];
            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new CustomListItem(frmCrudSocio);
                listItem[i].Title = "Codigo " + i.ToString() + " Morador Nome value " + i.ToString();
                listItem[i].Texto01 = "Descrição de valores";
                listItem[i].Texto02 = i.ToString();
                listItem[i].Texto03 = "Terciário";
                listItem[i].Texto04 = "Ver";




                flowLayoutPanel1.Controls.Add(listItem[i]);
            }
        }
    }
}