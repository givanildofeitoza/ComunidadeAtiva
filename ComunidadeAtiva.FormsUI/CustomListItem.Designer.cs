namespace ComunidadeAtiva.FormsUI
{
    partial class CustomListItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomListItem));
            TxtTitulo = new Label();
            txtInfo01 = new Label();
            txtInfo02 = new Label();
            panel1 = new Panel();
            imgBox = new PictureBox();
            imgAlter = new PictureBox();
            txtInfo03 = new Label();
            txtInfo04 = new Label();
            panel2 = new Panel();
            imgDelete = new PictureBox();
            lblLabelCodigo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAlter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDelete).BeginInit();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            TxtTitulo.Location = new Point(99, 19);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(78, 32);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "label1";
            TxtTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInfo01
            // 
            txtInfo01.AutoSize = true;
            txtInfo01.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtInfo01.ForeColor = SystemColors.WindowFrame;
            txtInfo01.Location = new Point(147, 53);
            txtInfo01.Name = "txtInfo01";
            txtInfo01.Size = new Size(38, 13);
            txtInfo01.TabIndex = 1;
            txtInfo01.Text = "label2";
            // 
            // txtInfo02
            // 
            txtInfo02.AutoSize = true;
            txtInfo02.ForeColor = SystemColors.WindowFrame;
            txtInfo02.Location = new Point(103, 72);
            txtInfo02.Name = "txtInfo02";
            txtInfo02.Size = new Size(38, 15);
            txtInfo02.TabIndex = 2;
            txtInfo02.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(imgBox);
            panel1.Controls.Add(imgAlter);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(98, 93);
            panel1.TabIndex = 3;
            // 
            // imgBox
            // 
            imgBox.Image = (Image)resources.GetObject("imgBox.Image");
            imgBox.Location = new Point(3, 0);
            imgBox.Name = "imgBox";
            imgBox.Size = new Size(30, 30);
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBox.TabIndex = 4;
            imgBox.TabStop = false;
            imgBox.Visible = false;
            // 
            // imgAlter
            // 
            imgAlter.Cursor = Cursors.Hand;
            imgAlter.Image = (Image)resources.GetObject("imgAlter.Image");
            imgAlter.Location = new Point(25, 22);
            imgAlter.Name = "imgAlter";
            imgAlter.Size = new Size(50, 50);
            imgAlter.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAlter.TabIndex = 8;
            imgAlter.TabStop = false;
            imgAlter.Click += imgAlter_Click;
            // 
            // txtInfo03
            // 
            txtInfo03.AutoSize = true;
            txtInfo03.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfo03.ForeColor = SystemColors.WindowFrame;
            txtInfo03.Location = new Point(390, 31);
            txtInfo03.Name = "txtInfo03";
            txtInfo03.Size = new Size(38, 13);
            txtInfo03.TabIndex = 4;
            txtInfo03.Text = "label2";
            // 
            // txtInfo04
            // 
            txtInfo04.AutoSize = true;
            txtInfo04.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfo04.ForeColor = SystemColors.WindowFrame;
            txtInfo04.Location = new Point(597, 31);
            txtInfo04.Name = "txtInfo04";
            txtInfo04.Size = new Size(38, 13);
            txtInfo04.TabIndex = 5;
            txtInfo04.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(104, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 2);
            panel2.TabIndex = 7;
            // 
            // imgDelete
            // 
            imgDelete.Cursor = Cursors.Hand;
            imgDelete.Image = (Image)resources.GetObject("imgDelete.Image");
            imgDelete.Location = new Point(605, 49);
            imgDelete.Name = "imgDelete";
            imgDelete.Size = new Size(23, 23);
            imgDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDelete.TabIndex = 9;
            imgDelete.TabStop = false;
            // 
            // lblLabelCodigo
            // 
            lblLabelCodigo.AutoSize = true;
            lblLabelCodigo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLabelCodigo.ForeColor = SystemColors.WindowFrame;
            lblLabelCodigo.Location = new Point(103, 53);
            lblLabelCodigo.Name = "lblLabelCodigo";
            lblLabelCodigo.Size = new Size(48, 13);
            lblLabelCodigo.TabIndex = 10;
            lblLabelCodigo.Text = "Código:";
            // 
            // CustomListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblLabelCodigo);
            Controls.Add(imgDelete);
            Controls.Add(panel2);
            Controls.Add(txtInfo04);
            Controls.Add(txtInfo03);
            Controls.Add(panel1);
            Controls.Add(txtInfo02);
            Controls.Add(txtInfo01);
            Controls.Add(TxtTitulo);
            Name = "CustomListItem";
            Size = new Size(789, 102);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAlter).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTitulo;
        private Label txtInfo01;
        private Label txtInfo02;
        private Panel panel1;
        private PictureBox imgBox;
        private Label txtInfo03;
        private Label txtInfo04;
        private Panel panel2;
        private PictureBox imgAlter;
        private PictureBox imgDelete;
        private Label lblLabelCodigo;
    }
}
