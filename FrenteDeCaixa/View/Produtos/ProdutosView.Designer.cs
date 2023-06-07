namespace FrenteDeCaixa.View.Produtos
{
    partial class ProdutosView
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtObs = new RichTextBox();
            label4 = new Label();
            txtVenda = new TextBox();
            label5 = new Label();
            txtCusto = new TextBox();
            label6 = new Label();
            txtEstoque = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            gridProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            txtId.Text = "1";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Produto:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 27);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex.: Produto";
            txtNome.Size = new Size(206, 23);
            txtNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Observação:";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(330, 27);
            txtObs.MaxLength = 50;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(276, 129);
            txtObs.TabIndex = 6;
            txtObs.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor de venda:";
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(12, 72);
            txtVenda.Name = "txtVenda";
            txtVenda.PlaceholderText = "Ex.: 0,00";
            txtVenda.Size = new Size(100, 23);
            txtVenda.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 54);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor de custo:";
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(118, 72);
            txtCusto.Name = "txtCusto";
            txtCusto.PlaceholderText = "Ex.: 0,00";
            txtCusto.Size = new Size(100, 23);
            txtCusto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 54);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(224, 72);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Ex.: 0,00";
            txtEstoque.Size = new Size(100, 23);
            txtEstoque.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(249, 133);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(168, 133);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(87, 133);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Location = new Point(12, 162);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowTemplate.Height = 25;
            gridProdutos.Size = new Size(594, 276);
            gridProdutos.TabIndex = 16;
            gridProdutos.CellContentClick += gridProdutos_CellContentClick;
            // 
            // ProdutosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(gridProdutos);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(txtEstoque);
            Controls.Add(label5);
            Controls.Add(txtCusto);
            Controls.Add(label4);
            Controls.Add(txtVenda);
            Controls.Add(txtObs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProdutosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private RichTextBox txtObs;
        private Label label4;
        private TextBox txtVenda;
        private Label label5;
        private TextBox txtCusto;
        private Label label6;
        private TextBox txtEstoque;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnNovo;
        private DataGridView gridProdutos;
    }
}