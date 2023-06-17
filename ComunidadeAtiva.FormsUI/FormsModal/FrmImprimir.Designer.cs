namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class FrmImprimir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cboTipo = new ComboBox();
            chkBenefico = new CheckBox();
            chkNecessidade = new CheckBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            cboOrdem = new ComboBox();
            label1 = new Label();
            chkRua = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(493, 212);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkRua);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cboOrdem);
            tabPage1.Controls.Add(cboTipo);
            tabPage1.Controls.Add(chkBenefico);
            tabPage1.Controls.Add(chkNecessidade);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 184);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Moradores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            cboTipo.DisplayMember = "0";
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "00 -Todos", "01 - Somente com necessidade" });
            cboTipo.Location = new Point(18, 96);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(310, 23);
            cboTipo.TabIndex = 0;
            cboTipo.Text = "Todos";
            cboTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // chkBenefico
            // 
            chkBenefico.AutoSize = true;
            chkBenefico.Location = new Point(19, 40);
            chkBenefico.Name = "chkBenefico";
            chkBenefico.Size = new Size(168, 19);
            chkBenefico.TabIndex = 5;
            chkBenefico.Text = "Imprimir Benefícios Sociais";
            chkBenefico.UseVisualStyleBackColor = true;
            // 
            // chkNecessidade
            // 
            chkNecessidade.AutoSize = true;
            chkNecessidade.Location = new Point(19, 15);
            chkNecessidade.Name = "chkNecessidade";
            chkNecessidade.Size = new Size(196, 19);
            chkNecessidade.TabIndex = 4;
            chkNecessidade.Text = "Imprimir Necessidades Especiais";
            chkNecessidade.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 125);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 3;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(485, 143);
            tabPage2.TabIndex = 1;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboOrdem
            // 
            cboOrdem.DisplayMember = "0";
            cboOrdem.FormattingEnabled = true;
            cboOrdem.Items.AddRange(new object[] { "0 - Morador", "1 - Rua" });
            cboOrdem.Location = new Point(364, 6);
            cboOrdem.Name = "cboOrdem";
            cboOrdem.Size = new Size(113, 23);
            cboOrdem.TabIndex = 6;
            cboOrdem.Text = "0 - Morador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 7;
            label1.Text = "Ordenar por:";
            // 
            // chkRua
            // 
            chkRua.AutoSize = true;
            chkRua.Location = new Point(19, 65);
            chkRua.Name = "chkRua";
            chkRua.Size = new Size(95, 19);
            chkRua.TabIndex = 8;
            chkRua.Text = "Imprimir Rua";
            chkRua.UseVisualStyleBackColor = true;
            // 
            // FrmImprimir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 224);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmImprimir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impressão de moradores";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox chkBenefico;
        private CheckBox chkNecessidade;
        private Button button1;
        private ComboBox cboTipo;
        private CheckBox chkRua;
        private Label label1;
        private ComboBox cboOrdem;
    }
}