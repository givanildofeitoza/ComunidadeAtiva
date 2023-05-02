namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class _FrmCrudRua
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            gridRua = new DataGridView();
            pnlCadRua = new Panel();
            txtCep = new TextBox();
            label10 = new Label();
            button5 = new Button();
            button4 = new Button();
            label9 = new Label();
            txtAgenteSaude = new TextBox();
            label8 = new Label();
            txtNomeAntigo = new TextBox();
            cboAgua = new ComboBox();
            cboSaneamento = new ComboBox();
            cboLixo = new ComboBox();
            cboEnergia = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboCalcada = new ComboBox();
            label7 = new Label();
            txtNome = new TextBox();
            button2 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRua).BeginInit();
            pnlCadRua.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 35);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(601, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Dados Ruas";
            // 
            // gridRua
            // 
            gridRua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRua.Dock = DockStyle.Top;
            gridRua.Location = new Point(0, 35);
            gridRua.Name = "gridRua";
            gridRua.RowTemplate.Height = 25;
            gridRua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRua.Size = new Size(676, 325);
            gridRua.TabIndex = 13;
            gridRua.CellEnter += gridRua_CellEnter;
            // 
            // pnlCadRua
            // 
            pnlCadRua.Controls.Add(txtCep);
            pnlCadRua.Controls.Add(label10);
            pnlCadRua.Controls.Add(button5);
            pnlCadRua.Controls.Add(button4);
            pnlCadRua.Controls.Add(label9);
            pnlCadRua.Controls.Add(txtAgenteSaude);
            pnlCadRua.Controls.Add(label8);
            pnlCadRua.Controls.Add(txtNomeAntigo);
            pnlCadRua.Controls.Add(cboAgua);
            pnlCadRua.Controls.Add(cboSaneamento);
            pnlCadRua.Controls.Add(cboLixo);
            pnlCadRua.Controls.Add(cboEnergia);
            pnlCadRua.Controls.Add(label6);
            pnlCadRua.Controls.Add(label5);
            pnlCadRua.Controls.Add(label4);
            pnlCadRua.Controls.Add(label3);
            pnlCadRua.Controls.Add(label2);
            pnlCadRua.Controls.Add(cboCalcada);
            pnlCadRua.Controls.Add(label7);
            pnlCadRua.Controls.Add(txtNome);
            pnlCadRua.Location = new Point(0, 35);
            pnlCadRua.Name = "pnlCadRua";
            pnlCadRua.Size = new Size(676, 367);
            pnlCadRua.TabIndex = 14;
            pnlCadRua.Visible = false;
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Location = new Point(329, 100);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(121, 23);
            txtCep.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(283, 103);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 37;
            label10.Text = "CPF:";
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(546, 63);
            button5.Name = "button5";
            button5.Size = new Size(109, 30);
            button5.TabIndex = 36;
            button5.Text = "CANCELAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(546, 20);
            button4.Name = "button4";
            button4.Size = new Size(109, 30);
            button4.TabIndex = 35;
            button4.Text = "CONFIRMAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 103);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 34;
            label9.Text = "Agente Saúde:";
            // 
            // txtAgenteSaude
            // 
            txtAgenteSaude.BorderStyle = BorderStyle.FixedSingle;
            txtAgenteSaude.Location = new Point(93, 101);
            txtAgenteSaude.Name = "txtAgenteSaude";
            txtAgenteSaude.Size = new Size(184, 23);
            txtAgenteSaude.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 63);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 32;
            label8.Text = "Nome Antigo:";
            // 
            // txtNomeAntigo
            // 
            txtNomeAntigo.BorderStyle = BorderStyle.FixedSingle;
            txtNomeAntigo.Location = new Point(93, 61);
            txtNomeAntigo.Name = "txtNomeAntigo";
            txtNomeAntigo.Size = new Size(358, 23);
            txtNomeAntigo.TabIndex = 31;
            // 
            // cboAgua
            // 
            cboAgua.FlatStyle = FlatStyle.Flat;
            cboAgua.FormattingEnabled = true;
            cboAgua.Items.AddRange(new object[] { "S", "N" });
            cboAgua.Location = new Point(210, 162);
            cboAgua.Name = "cboAgua";
            cboAgua.Size = new Size(67, 23);
            cboAgua.TabIndex = 30;
            cboAgua.Text = "S";
            // 
            // cboSaneamento
            // 
            cboSaneamento.FlatStyle = FlatStyle.Flat;
            cboSaneamento.FormattingEnabled = true;
            cboSaneamento.Items.AddRange(new object[] { "S", "N" });
            cboSaneamento.Location = new Point(386, 162);
            cboSaneamento.Name = "cboSaneamento";
            cboSaneamento.Size = new Size(67, 23);
            cboSaneamento.TabIndex = 28;
            cboSaneamento.Text = "S";
            // 
            // cboLixo
            // 
            cboLixo.FlatStyle = FlatStyle.Flat;
            cboLixo.FormattingEnabled = true;
            cboLixo.Items.AddRange(new object[] { "S", "N" });
            cboLixo.Location = new Point(296, 162);
            cboLixo.Name = "cboLixo";
            cboLixo.Size = new Size(67, 23);
            cboLixo.TabIndex = 27;
            cboLixo.Text = "S";
            // 
            // cboEnergia
            // 
            cboEnergia.FlatStyle = FlatStyle.Flat;
            cboEnergia.FormattingEnabled = true;
            cboEnergia.Items.AddRange(new object[] { "S", "N" });
            cboEnergia.Location = new Point(129, 161);
            cboEnergia.Name = "cboEnergia";
            cboEnergia.Size = new Size(67, 23);
            cboEnergia.TabIndex = 26;
            cboEnergia.Text = "S";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 137);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 25;
            label6.Text = "C. Lixo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 137);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 24;
            label5.Text = "Saneamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 137);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 23;
            label4.Text = "Água:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 137);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 22;
            label3.Text = "Energia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 137);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 21;
            label2.Text = "Calçada:";
            // 
            // cboCalcada
            // 
            cboCalcada.FlatStyle = FlatStyle.Flat;
            cboCalcada.FormattingEnabled = true;
            cboCalcada.Items.AddRange(new object[] { "S", "N" });
            cboCalcada.Location = new Point(39, 161);
            cboCalcada.Name = "cboCalcada";
            cboCalcada.Size = new Size(67, 23);
            cboCalcada.TabIndex = 19;
            cboCalcada.Text = "S";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 22);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 18;
            label7.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(94, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 23);
            txtNome.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(409, 372);
            button2.Name = "button2";
            button2.Size = new Size(109, 30);
            button2.TabIndex = 36;
            button2.Text = "CADASTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(533, 372);
            button6.Name = "button6";
            button6.Size = new Size(109, 30);
            button6.TabIndex = 37;
            button6.Text = "ALTERAR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // _FrmCrudRua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(676, 414);
            Controls.Add(pnlCadRua);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(gridRua);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_FrmCrudRua";
            StartPosition = FormStartPosition.CenterParent;
            Shown += FrmCrudRua_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRua).EndInit();
            pnlCadRua.ResumeLayout(false);
            pnlCadRua.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private DataGridView gridRua;
        private Panel pnlCadRua;
        private Label label7;
        private TextBox txtNome;
        private Button button5;
        private Button button4;
        private Label label9;
        private TextBox txtAgenteSaude;
        private Label label8;
        private TextBox txtNomeAntigo;
        private ComboBox cboAgua;
        private ComboBox cboSaneamento;
        private ComboBox cboLixo;
        private ComboBox cboEnergia;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboCalcada;
        private TextBox txtCep;
        private Label label10;
        private Button button6;
    }
}