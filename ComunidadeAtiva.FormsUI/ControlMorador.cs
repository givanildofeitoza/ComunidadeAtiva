using ComunidadeAtiva.Dominio.Entity;
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
    public partial class ControlMorador : UserControl
    {
        public ControlMorador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* CustomListItem[] listItem = new CustomListItem[20];
             for(int i=0; i<= listItem.Length; i++)
             {
                 listItem[i] = new CustomListItem();
                 listItem[i].Title = "Codigo " + i.ToString() + " Morador Nome value " + i.ToString();
                 listItem[i].Texto01 = "Descrição de valores";
                 listItem[i].Texto02 = "Secundário";
                 listItem[i].Texto03 = "Terciário";
                 listItem[i].Texto04 = "Ver";

                 flowLayoutPanel1.Controls.Clear();
                 flowLayoutPanel1.Controls.Add(listItem[i]);
             }*/
        }
    }
}
