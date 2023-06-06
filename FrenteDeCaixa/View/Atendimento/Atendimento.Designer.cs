namespace FrenteDeCaixa
{
    partial class Atendimento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            dgvProdutos = new DataGridView();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 52);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(136, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ex.: Consumidor";
            textBox1.Size = new Size(704, 33);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Clientes:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvProdutos);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 610);
            panel4.TabIndex = 3;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(0, 0);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(846, 610);
            dgvProdutos.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1154, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(122, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(122, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(846, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 705);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 95);
            label9.Name = "label9";
            label9.Size = new Size(160, 19);
            label9.TabIndex = 23;
            label9.Text = "F3 - Finalizar a venda";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 67);
            label8.Name = "label8";
            label8.Size = new Size(193, 19);
            label8.TabIndex = 22;
            label8.Text = "F2 - Pesquisa de produtos";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 41);
            label7.Name = "label7";
            label7.Size = new Size(182, 19);
            label7.TabIndex = 21;
            label7.Text = "F1 - Pesquisa de clientes";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 10);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 20;
            label6.Text = "Atalhos";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 660);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 45);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(74, 35);
            label1.TabIndex = 6;
            label1.Text = "Total:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 10);
            label5.Name = "label5";
            label5.Size = new Size(219, 35);
            label5.TabIndex = 5;
            label5.Text = "0,00";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(308, 10);
            panel6.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 43);
            panel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(549, 43);
            panel8.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(136, 6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ex.: Arroz 5kg";
            textBox2.Size = new Size(410, 33);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 19;
            label3.Text = "Produtos:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(label4);
            panel7.Controls.Add(textBox3);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(549, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(297, 43);
            panel7.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 23;
            label4.Text = "Quantidade:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(153, 6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ex.: 0,00";
            textBox3.Size = new Size(138, 33);
            textBox3.TabIndex = 2;
            // 
            // Atendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 729);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1024, 768);
            Name = "Atendimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atendimento";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Label label5;
        private Panel panel6;
        private Panel panel3;
        private Panel panel8;
        private TextBox textBox2;
        private Label label3;
        private Panel panel7;
        private Label label4;
        private TextBox textBox3;
        private DataGridView dgvProdutos;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}