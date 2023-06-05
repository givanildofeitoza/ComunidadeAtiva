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
            chkBenefico = new CheckBox();
            chkNecessidade = new CheckBox();
            button1 = new Button();
            tabPage2 = new TabPage();
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
            tabControl1.Size = new Size(493, 171);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkBenefico);
            tabPage1.Controls.Add(chkNecessidade);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 143);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Moradores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkBenefico
            // 
            chkBenefico.AutoSize = true;
            chkBenefico.Location = new Point(19, 40);
            chkBenefico.Name = "chkBenefico";
            chkBenefico.Size = new Size(119, 19);
            chkBenefico.TabIndex = 5;
            chkBenefico.Text = "Benefícios Sociais";
            chkBenefico.UseVisualStyleBackColor = true;
            // 
            // chkNecessidade
            // 
            chkNecessidade.AutoSize = true;
            chkNecessidade.Location = new Point(19, 15);
            chkNecessidade.Name = "chkNecessidade";
            chkNecessidade.Size = new Size(147, 19);
            chkNecessidade.TabIndex = 4;
            chkNecessidade.Text = "Necessidades Especiais";
            chkNecessidade.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
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
            // FrmImprimir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 188);
            Controls.Add(tabControl1);
            Name = "FrmImprimir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmImprimir";
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
    }
}