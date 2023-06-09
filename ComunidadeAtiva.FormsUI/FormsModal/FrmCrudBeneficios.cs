﻿using ComunidadeAtiva.Aplicacao.CasosDeUso;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
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
    public partial class _FrmCrudBeneficios : ClasseFormPadrao
    {
        private MoradorDTO moradorAtivo;
        private int IdBeneficio;

        public _FrmCrudBeneficios(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public async Task CarregarBeneficios()
        {
            cboBeneficio.Items.Clear();
            moradorAtivo = await FrmMain._ServicoMorador.ObterMoradorRelacionalRuaId(Id);
            var beneficios = await FrmMain._beneficioSocial.ObterTodos(50, 0);
            List<BeneficosMoradorDTO> BeneficiosMorador = new List<BeneficosMoradorDTO>();
            foreach (var b in moradorAtivo.moradorBeneficioSocial)
            {
                BeneficiosMorador.Add(
                new BeneficosMoradorDTO
                {
                    id = b.id,
                    DescricaoBeneficio = beneficios.Where(x => x.id == b.BeneficioSocialId).FirstOrDefault().NomeBeneficioSocial,
                    Valor = b.Valor
                });
            }
            var tabela = BeneficiosMorador.Select(x => new
            {
                Id = x.id,
                Descricao = x.DescricaoBeneficio,
                Valor = x.Valor

            }).ToList();
            GridBeneficio.DataSource = tabela;

        }

        private async void _FrmCrudBeneficios_Load(object sender, EventArgs e)
        {
            await CarregarBeneficios();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pnlLancar.Visible = true;
            cboBeneficio.Items.Clear();
            var beneficios = await FrmMain._beneficioSocial.ObterTodos(50, 0);
            foreach (var b in beneficios)
            {
                cboBeneficio.Items.Add($"{b.id.ToString().PadLeft(4, '0')}-{b.NomeBeneficioSocial}");
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var idBeneficio = int.Parse(cboBeneficio.Text.Substring(0, 4));
            if (moradorAtivo.moradorBeneficioSocial.Where(x => x.BeneficioSocialId == idBeneficio).Count() > 0)
            {
                MessageBox.Show("Benefício já informado!");
                return;

            }

            BeneficosMoradorDTO b = new BeneficosMoradorDTO();
            b.MoradorId = Id;
            b.BeneficioSocialId = idBeneficio;
            b.Valor = decimal.Parse(txtValor.Text);
            await FrmMain._ServicoBeneficoSocialMorador.CadastrarBeneficioMorador(b);
            await CarregarBeneficios();
            pnlLancar.Visible = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {

            var dlg = MessageBox.Show("Confirmar Exclusão do valor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                return;

            var b = await FrmMain._ServicoBeneficoSocialMorador.ObterBeneficioMoradorID(IdBeneficio);
            if (b == null)
                return;

            await FrmMain._ServicoBeneficoSocialMorador.DeletarBeneficioMorador(b);
            await CarregarBeneficios();
        }

        private void GridBeneficio_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IdBeneficio = int.Parse(GridBeneficio.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlLancar.Visible = false;
        }
    }
}
