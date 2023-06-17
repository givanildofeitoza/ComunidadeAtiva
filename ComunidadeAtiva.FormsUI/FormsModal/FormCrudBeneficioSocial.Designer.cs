namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class FormCrudBeneficioSocial
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
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtDesc = new TextBox();
            pnlId = new Panel();
            label4 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            pnlId.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 35);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(305, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 78);
            panel2.TabIndex = 22;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(469, 0);
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
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Benefícios Sociais";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(36, 251);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 13;
            button2.Text = "CONFIRMAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(35, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(109, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome do Benefício";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(486, 23);
            txtNome.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 19;
            label3.Text = "Descrição do Benefício";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(35, 168);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(486, 61);
            txtDesc.TabIndex = 18;
            // 
            // pnlId
            // 
            pnlId.Controls.Add(label4);
            pnlId.Controls.Add(txtId);
            pnlId.Location = new Point(36, 37);
            pnlId.Name = "pnlId";
            pnlId.Size = new Size(137, 59);
            pnlId.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 23;
            label4.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(3, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(109, 23);
            txtId.TabIndex = 22;
            // 
            // FormCrudBeneficioSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 294);
            Controls.Add(pnlId);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormCrudBeneficioSocial";
            StartPosition = FormStartPosition.CenterParent;
            Shown += FormCrudBeneficioSocial_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlId.ResumeLayout(false);
            pnlId.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label lblNome;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtDesc;
        private Panel panel2;
        private Panel pnlId;
        private Label label4;
        private TextBox txtId;
    }
}