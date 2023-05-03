namespace ComunidadeAtiva.FormsUI.FormsModal
{
    partial class _FrmCrudBeneficios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FrmCrudBeneficios));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            GridBeneficio = new DataGridView();
            pnlLancar = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            txtValor = new TextBox();
            cboBeneficio = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBeneficio).BeginInit();
            pnlLancar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(461, 35);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(386, 0);
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
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 408);
            button3.Name = "button3";
            button3.Size = new Size(131, 30);
            button3.TabIndex = 11;
            button3.Text = "EXCLUIR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(166, 408);
            button2.Name = "button2";
            button2.Size = new Size(131, 30);
            button2.TabIndex = 12;
            button2.Text = "ADICIONAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GridBeneficio
            // 
            GridBeneficio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBeneficio.Dock = DockStyle.Top;
            GridBeneficio.Location = new Point(0, 35);
            GridBeneficio.Name = "GridBeneficio";
            GridBeneficio.RowTemplate.Height = 25;
            GridBeneficio.Size = new Size(461, 356);
            GridBeneficio.TabIndex = 13;
            // 
            // pnlLancar
            // 
            pnlLancar.Controls.Add(pictureBox1);
            pnlLancar.Controls.Add(label3);
            pnlLancar.Controls.Add(label2);
            pnlLancar.Controls.Add(txtValor);
            pnlLancar.Controls.Add(cboBeneficio);
            pnlLancar.Location = new Point(35, 78);
            pnlLancar.Name = "pnlLancar";
            pnlLancar.Size = new Size(395, 143);
            pnlLancar.TabIndex = 14;
            pnlLancar.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(201, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 72);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Valor R$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 20);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Benefício";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(40, 95);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(138, 23);
            txtValor.TabIndex = 1;
            // 
            // cboBeneficio
            // 
            cboBeneficio.FormattingEnabled = true;
            cboBeneficio.Location = new Point(40, 41);
            cboBeneficio.Name = "cboBeneficio";
            cboBeneficio.Size = new Size(321, 23);
            cboBeneficio.TabIndex = 0;
            // 
            // _FrmCrudBeneficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 450);
            Controls.Add(pnlLancar);
            Controls.Add(GridBeneficio);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_FrmCrudBeneficios";
            StartPosition = FormStartPosition.CenterParent;
            Load += _FrmCrudBeneficios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridBeneficio).EndInit();
            pnlLancar.ResumeLayout(false);
            pnlLancar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private DataGridView GridBeneficio;
        private Panel pnlLancar;
        private Label label3;
        private Label label2;
        private TextBox txtValor;
        private ComboBox cboBeneficio;
        private PictureBox pictureBox1;
    }
}