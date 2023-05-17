namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class _FrmCrudNecessidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FrmCrudNecessidades));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            gridNcessidade = new DataGridView();
            pnlListaNecessidade = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cbonecessidade = new ComboBox();
            button3 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridNcessidade).BeginInit();
            pnlListaNecessidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(442, 35);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(367, 0);
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
            label1.Size = new Size(265, 25);
            label1.TabIndex = 0;
            label1.Text = "Dados Necessidades Especiais";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(127, 354);
            button2.Name = "button2";
            button2.Size = new Size(109, 30);
            button2.TabIndex = 37;
            button2.Text = "ADICIONAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // gridNcessidade
            // 
            gridNcessidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNcessidade.Dock = DockStyle.Top;
            gridNcessidade.Location = new Point(0, 35);
            gridNcessidade.Name = "gridNcessidade";
            gridNcessidade.RowTemplate.Height = 25;
            gridNcessidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNcessidade.Size = new Size(442, 313);
            gridNcessidade.TabIndex = 38;
            gridNcessidade.CellEnter += gridNcessidade_CellEnter;
            // 
            // pnlListaNecessidade
            // 
            pnlListaNecessidade.Controls.Add(panel2);
            pnlListaNecessidade.Controls.Add(pictureBox1);
            pnlListaNecessidade.Controls.Add(label2);
            pnlListaNecessidade.Controls.Add(cbonecessidade);
            pnlListaNecessidade.Location = new Point(64, 79);
            pnlListaNecessidade.Name = "pnlListaNecessidade";
            pnlListaNecessidade.Size = new Size(350, 139);
            pnlListaNecessidade.TabIndex = 39;
            pnlListaNecessidade.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecionar Necessidade";
            // 
            // cbonecessidade
            // 
            cbonecessidade.FormattingEnabled = true;
            cbonecessidade.Location = new Point(26, 87);
            cbonecessidade.Name = "cbonecessidade";
            cbonecessidade.Size = new Size(261, 23);
            cbonecessidade.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 354);
            button3.Name = "button3";
            button3.Size = new Size(109, 30);
            button3.TabIndex = 40;
            button3.Text = "EXCLUIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 36);
            panel2.TabIndex = 35;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(275, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 36);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // _FrmCrudNecessidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 391);
            Controls.Add(button3);
            Controls.Add(pnlListaNecessidade);
            Controls.Add(gridNcessidade);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_FrmCrudNecessidades";
            StartPosition = FormStartPosition.CenterParent;
            Load += _FrmCrudNecessidades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridNcessidade).EndInit();
            pnlListaNecessidade.ResumeLayout(false);
            pnlListaNecessidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private DataGridView gridNcessidade;
        private Panel pnlListaNecessidade;
        private Label label2;
        private ComboBox cbonecessidade;
        private PictureBox pictureBox1;
        private Button button3;
        private Panel panel2;
        private Button button4;
    }
}