using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Dominio.Enum;
using ComunidadeAtiva.FormsUI.Classes;
using ComunidadeAtiva.FormsUI.FormsModal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunidadeAtiva.FormsUI
{
    public partial class CustomListItem : UserControl
    {
        private ClasseFormPadrao _frm;
        public string  BoundedContext;

        public CustomListItem(ClasseFormPadrao frm)
        {
            _frm = frm;
            InitializeComponent();
        }
        private string _title;
        private string _texto01;
        private string _texto02;
        private string _texto03;
        private string _texto04;
        private Image _img;
        private Image _imgBtnAlter;
        private Image _imgBtnDelete;

        private void imgAlter_Click(object sender, EventArgs e)
        {
            _frm.Id = int.Parse(_texto01);
            _frm.ShowDialog();
        }

        private async void imgDelete_Click(object sender, EventArgs e)
        {
            switch (BoundedContext)
            {
                case "MORADORES":
                    {
                         DialogResult result = MessageBox.Show("Excluir Morador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         if (result == DialogResult.No)
                         return;
                     

                       var morador = await FrmMain._ServicoMorador.ObterMoradorId(int.Parse(_texto01));
                        morador.Situacao = "Excluído";
                        await FrmMain._ServicoMorador.AlterarMorador(morador);

                        break;
                    }
                case "NECESSIDADES ESPECIAIS":
                    {
                        DialogResult result = MessageBox.Show("Excluir Necessiade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            return;

                        var necessidade = await FrmMain._ServicoNecessidadeEspecial.ObterNecessidadeID(int.Parse(_texto01));
                        await FrmMain._ServicoNecessidadeEspecial.DeletarNecessidade(necessidade);
                        await FrmMain._ServicoNecessidadeMorador.DeletarNecessidadePorIdNecessidade(int.Parse(_texto01));                       

                        break;
                    }
                case "PROGRAMAS SOCIAIS":
                    {
                        DialogResult result = MessageBox.Show("Excluir Programa Social?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            return;

                        var beneficio = await FrmMain._ServicoBeneficioSocial.ObterBeneficioID(int.Parse(_texto01));
                        await FrmMain._ServicoBeneficioSocial.DeletarBeneficio(beneficio);                       
                        await FrmMain._ServicoBeneficoSocialMorador.DeletarPorIdBbeneficio(int.Parse(_texto01));

                        break;
                    }
            }
        }

        [Category("Custom Props")]
        public Image ImgBtnDelete
        {
            get { return _imgBtnDelete; }
            set { _imgBtnDelete = value; imgDelete.Image = value; }
        }

        [Category("Custom Props")]
        public Image ImgBtnAlter
        {
            get { return _imgBtnAlter; }
            set { _imgBtnAlter = value; imgAlter.Image = value; }
        }

        [Category("Custom Props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; imgBox.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; TxtTitulo.Text = value; }
        }

        [Category("Custom Props")]
        public string Texto01
        {
            get { return _texto01; }
            set { _texto01 = value; txtInfo01.Text = value; }
        }
        [Category("Custom Props")]
        public string Texto02
        {
            get { return _texto02; }
            set { _texto02 = value; txtInfo02.Text = value; }
        }

        [Category("Custom Props")]
        public string Texto03
        {
            get { return _texto03; }
            set { _texto03 = value; txtInfo03.Text = value; }
        }

        [Category("Custom Props")]
        public string Texto04
        {
            get { return _texto04; }
            set { _texto04 = value; txtInfo04.Text = value; }
        }
    }
}
