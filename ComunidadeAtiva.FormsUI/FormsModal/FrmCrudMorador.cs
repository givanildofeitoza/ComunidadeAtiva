using ComunidadeAtiva.FormsUI.Classes;
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
        public _FrmCrudMorador()
        {
            InitializeComponent();

        }

        private void _FrmCrudMorador_Shown(object sender, EventArgs e)
        {
            label1.Text = "Morador: " + Id.ToString();
        }
    }
}
