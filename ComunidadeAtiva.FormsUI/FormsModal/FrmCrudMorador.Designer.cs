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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Dados Morador";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(73, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(96, 23);
            txtId.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 35);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(633, 0);
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
            txtRg.Location = new Point(73, 143);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(96, 23);
            txtRg.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(224, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(446, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Location = new Point(224, 143);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(257, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtDescRua
            // 
            txtDescRua.BorderStyle = BorderStyle.FixedSingle;
            txtDescRua.Location = new Point(73, 219);
            txtDescRua.Multiline = true;
            txtDescRua.Name = "txtDescRua";
            txtDescRua.Size = new Size(408, 103);
            txtDescRua.TabIndex = 6;
            // 
            // txtIdRua
            // 
            txtIdRua.BorderStyle = BorderStyle.FixedSingle;
            txtIdRua.Location = new Point(73, 182);
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
            cboEstadoCivil.Location = new Point(373, 181);
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
            button3.Location = new Point(73, 340);
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
            label2.Location = new Point(296, 184);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 11;
            label2.Text = "Estado Civil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 184);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 13;
            label4.Text = "Id Rua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 145);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 14;
            label5.Text = "RG:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 103);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 15;
            label6.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 145);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 16;
            label7.Text = "CPF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 97);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "Nome:";
            // 
            // cboSituacao
            // 
            cboSituacao.FlatStyle = FlatStyle.Flat;
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboSituacao.Location = new Point(564, 142);
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(107, 23);
            cboSituacao.TabIndex = 18;
            cboSituacao.Text = "Ativo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 145);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
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
            button2.Location = new Point(157, 181);
            button2.Name = "button2";
            button2.Size = new Size(31, 24);
            button2.TabIndex = 20;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(564, 178);
            txtData.Name = "txtData";
            txtData.Size = new Size(106, 23);
            txtData.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 182);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 22;
            label3.Text = "Nascimento:";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(224, 182);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(66, 23);
            txtNumero.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(194, 186);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 24;
            label10.Text = "Nº:";
            // 
            // _FrmCrudMorador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 392);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_FrmCrudMorador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrudMorador";
            panel1.ResumeLayout(false);
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
    }
}