namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class FrmCrudNecessidade
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
            label1 = new Label();
            cboRemedio = new ComboBox();
            cboPermanente = new ComboBox();
            txtDescricao = new TextBox();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 17);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Necessidades Especiais";
            // 
            // cboRemedio
            // 
            cboRemedio.FormattingEnabled = true;
            cboRemedio.Items.AddRange(new object[] { "S", "N" });
            cboRemedio.Location = new Point(152, 158);
            cboRemedio.Name = "cboRemedio";
            cboRemedio.Size = new Size(82, 23);
            cboRemedio.TabIndex = 1;
            cboRemedio.Text = "N";
            // 
            // cboPermanente
            // 
            cboPermanente.FormattingEnabled = true;
            cboPermanente.Items.AddRange(new object[] { "S", "N" });
            cboPermanente.Location = new Point(152, 115);
            cboPermanente.Name = "cboPermanente";
            cboPermanente.Size = new Size(82, 23);
            cboPermanente.TabIndex = 1;
            cboPermanente.Text = "N";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(103, 74);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(379, 23);
            txtDescricao.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(37, 213);
            button4.Name = "button4";
            button4.Size = new Size(109, 30);
            button4.TabIndex = 36;
            button4.Text = "CONFIRMAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 37;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 161);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 38;
            label3.Text = "Remédio Controlado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 115);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 39;
            label4.Text = "Permanente";
            // 
            // FrmCrudNecessidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 264);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(txtDescricao);
            Controls.Add(cboPermanente);
            Controls.Add(cboRemedio);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCrudNecessidade";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cboRemedio;
        private ComboBox cboPermanente;
        private TextBox txtDescricao;
        private Label label1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}