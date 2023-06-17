namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "givanildo@bol.com.br";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(74, 125);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 23);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "Abc@123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 49);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 107);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(74, 164);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 247);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}