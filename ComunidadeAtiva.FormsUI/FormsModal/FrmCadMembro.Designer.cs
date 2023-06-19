namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class FrmCadMembro
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            cboNivel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApelido = new Label();
            textBox1 = new TextBox();
            txtFone = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(452, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(25, 329);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(258, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(26, 379);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.PasswordChar = '*';
            txtConfSenha.Size = new Size(258, 23);
            txtConfSenha.TabIndex = 3;
            // 
            // cboNivel
            // 
            cboNivel.FormattingEnabled = true;
            cboNivel.Items.AddRange(new object[] { "1-Comum", "2-Pleno", "3-Sênior" });
            cboNivel.Location = new Point(25, 180);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(121, 23);
            cboNivel.TabIndex = 4;
            cboNivel.Text = "1-Comum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 108);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 357);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 6;
            label2.Text = "Confirmar Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 310);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 259);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 8;
            label4.Text = "E-mail (Usuário de Login)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 158);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 9;
            label5.Text = "Nível de Acesso";
            // 
            // txtApelido
            // 
            txtApelido.AutoSize = true;
            txtApelido.Location = new Point(31, 60);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(48, 15);
            txtApelido.TabIndex = 11;
            txtApelido.Text = "Apelido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 10;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(167, 180);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(209, 23);
            txtFone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 158);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Telefone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 50);
            panel1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(48, 9);
            label11.Name = "label11";
            label11.Size = new Size(446, 32);
            label11.TabIndex = 3;
            label11.Text = "Cadastro de mebro / Registro de usuário";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 411);
            button1.Name = "button1";
            button1.Size = new Size(144, 33);
            button1.TabIndex = 15;
            button1.Text = "CONFIRMAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmCadMembro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 468);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtFone);
            Controls.Add(txtApelido);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboNivel);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmCadMembro";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private ComboBox cboNivel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtApelido;
        private TextBox textBox1;
        private TextBox txtFone;
        private Label label6;
        private Panel panel1;
        private Label label11;
        private Button button1;
    }
}