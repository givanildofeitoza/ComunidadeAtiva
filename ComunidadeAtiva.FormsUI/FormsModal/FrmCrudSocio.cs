﻿using ComunidadeAtiva.FormsUI.Classes;
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
    public partial class _FrmCrudSocio : ClasseFormPadrao
    {
        
        public _FrmCrudSocio()
        {
            InitializeComponent();
        }
        //public int Id;

        private void _FrmCrudSocio_Load(object sender, EventArgs e)
        {
            label1.Text = "Socio: " + Id.ToString();
        }
    }
}
