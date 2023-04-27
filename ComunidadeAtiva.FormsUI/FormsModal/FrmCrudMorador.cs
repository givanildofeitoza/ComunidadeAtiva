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

namespace ComunidadeAtiva.FormsUI.FormsModal
{
    public partial class _FrmCrudMorador : ClasseFormPadrao
    {
        public static int Id;
        private readonly FileDbContext _db;
        private readonly Imorador _Morador;
        public _FrmCrudMorador(Imorador Morador, FileDbContext db)
        {
            InitializeComponent();
            _Morador = Morador;
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
            m.IdRua = int.Parse(txtIdRua.Text);
            m.Nascimento = Convert.ToDateTime(txtData.Text);
            m.NumeroCasa = txtNumero.Text;
            _Morador.CadastrarMorador(m);
            MessageBox.Show("Cadastrado com Sucesso!");
        }
    }
}
