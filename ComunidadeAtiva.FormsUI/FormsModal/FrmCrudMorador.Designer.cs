namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class _FrmCrudMorador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FrmCrudMorador));
            label1 = new Label();
            txtId = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            txtRg = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtDescRua = new TextBox();
            txtIdRua = new TextBox();
            cboEstadoCivil = new ComboBox();
            button3 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cboSituacao = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            txtData = new DateTimePicker();
            label3 = new Label();
            txtNumero = new TextBox();
            label10 = new Label();
            label11 = new Label();
            ListBoxBeneficio = new ListBox();
            label12 = new Label();
            ListBoxNecessidade = new ListBox();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Dados Morador";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(72, 61);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(96, 23);
            txtId.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 35);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(641, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRg
            // 
            txtRg.BorderStyle = BorderStyle.FixedSingle;
            txtRg.Location = new Point(72, 109);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(96, 23);
            txtRg.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(223, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(446, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Location = new Point(223, 109);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(257, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtDescRua
            // 
            txtDescRua.BorderStyle = BorderStyle.FixedSingle;
            txtDescRua.Location = new Point(72, 207);
            txtDescRua.Multiline = true;
            txtDescRua.Name = "txtDescRua";
            txtDescRua.Size = new Size(597, 144);
            txtDescRua.TabIndex = 6;
            // 
            // txtIdRua
            // 
            txtIdRua.BorderStyle = BorderStyle.FixedSingle;
            txtIdRua.Location = new Point(72, 148);
            txtIdRua.Name = "txtIdRua";
            txtIdRua.ReadOnly = true;
            txtIdRua.Size = new Size(78, 23);
            txtIdRua.TabIndex = 7;
            txtIdRua.Text = "1";
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.FlatStyle = FlatStyle.Flat;
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Divorciado", "Viúvo" });
            cboEstadoCivil.Location = new Point(372, 147);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(108, 23);
            cboEstadoCivil.TabIndex = 9;
            cboEstadoCivil.Text = "Solteiro";
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(72, 492);
            button3.Name = "button3";
            button3.Size = new Size(131, 30);
            button3.TabIndex = 10;
            button3.Text = "CONFIRMAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 150);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Estado Civil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 150);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 13;
            label4.Text = "Id Rua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 111);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 14;
            label5.Text = "RG:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 69);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 15;
            label6.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 111);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "CPF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(174, 63);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 17;
            label8.Text = "Nome:";
            // 
            // cboSituacao
            // 
            cboSituacao.FlatStyle = FlatStyle.Flat;
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboSituacao.Location = new Point(563, 108);
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(107, 23);
            cboSituacao.TabIndex = 18;
            cboSituacao.Text = "Ativo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 111);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 19;
            label9.Text = "Situação:";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(156, 147);
            button2.Name = "button2";
            button2.Size = new Size(31, 24);
            button2.TabIndex = 20;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(563, 144);
            txtData.Name = "txtData";
            txtData.Size = new Size(106, 23);
            txtData.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 148);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 22;
            label3.Text = "Nascimento:";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(223, 148);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(66, 23);
            txtNumero.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 152);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 24;
            label10.Text = "Nº:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(72, 183);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 25;
            label11.Text = "Informações da Rua:";
            // 
            // ListBoxBeneficio
            // 
            ListBoxBeneficio.FormattingEnabled = true;
            ListBoxBeneficio.ItemHeight = 15;
            ListBoxBeneficio.Location = new Point(72, 392);
            ListBoxBeneficio.Name = "ListBoxBeneficio";
            ListBoxBeneficio.Size = new Size(282, 94);
            ListBoxBeneficio.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 372);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 29;
            label12.Text = "Benefício Social:";
            // 
            // ListBoxNecessidade
            // 
            ListBoxNecessidade.FormattingEnabled = true;
            ListBoxNecessidade.ItemHeight = 15;
            ListBoxNecessidade.Location = new Point(372, 392);
            ListBoxNecessidade.Name = "ListBoxNecessidade";
            ListBoxNecessidade.Size = new Size(297, 94);
            ListBoxNecessidade.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(372, 371);
            label13.Name = "label13";
            label13.Size = new Size(125, 15);
            label13.TabIndex = 31;
            label13.Text = "Necessidade Especial:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(169, 364);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // _FrmCrudMorador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 533);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(ListBoxNecessidade);
            Controls.Add(label12);
            Controls.Add(ListBoxBeneficio);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(txtData);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(cboSituacao);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(cboEstadoCivil);
            Controls.Add(txtIdRua);
            Controls.Add(txtDescRua);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtRg);
            Controls.Add(panel1);
            Controls.Add(txtId);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_FrmCrudMorador";
            StartPosition = FormStartPosition.CenterScreen;
            Load += _FrmCrudMorador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Panel panel1;
        private Button button1;
        private TextBox txtRg;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtDescRua;
        private TextBox txtIdRua;
        private ComboBox cboEstadoCivil;
        private Button button3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cboSituacao;
        private Label label9;
        private Button button2;
        private DateTimePicker txtData;
        private Label label3;
        private TextBox txtNumero;
        private Label label10;
        private Label label11;
        private ListBox ListBoxBeneficio;
        private Label label12;
        private ListBox ListBoxNecessidade;
        private Label label13;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}