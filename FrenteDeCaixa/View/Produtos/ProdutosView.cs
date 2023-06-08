using FrenteDeCaixa.Model;
using FrenteDeCaixa.Presenter;
using FrenteDeCaixa.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteDeCaixa.View.Produtos
{
    public partial class ProdutosView : Form, IProdutosView
    {
        private ProdutosPresenter presenter;

        public ProdutosView()
        {
            InitializeComponent();
            presenter = new ProdutosPresenter(this);
            AssociarEvento();
        }

        public int Id
        {
            get
            {
                return txtId.Text.ConverterIntStr(1);
            }
            set
            {
                txtId.Text = value.ToString();
            }
        }
        public string Nome
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;
            }
        }
        public string? Observacao
        {
            get
            {
                return txtObs.Text;
            }
            set
            {
                txtObs.Text = value;
            }
        }
        public decimal Venda
        {
            get
            {
                return txtVenda.Text.ConverterDecimalStr();
            }
            set
            {
                txtVenda.Text = value.ToString();
            }
        }
        public decimal Custo
        {
            get
            {
                return txtCusto.Text.ConverterDecimalStr();
            }
            set
            {
                txtCusto.Text = value.ToString();
            }
        }
        public decimal Estoque
        {
            get
            {
                return txtEstoque.Text.ConverterDecimalStr();
            }
            set
            {
                txtEstoque.Text = value.ToString();
            }
        }

        public void AssociarEvento()
        {
            
            btnExcluir.Click += delegate { excluirProduto?.Invoke(this, EventArgs.Empty); };
            btnNovo.Click += delegate { novoProduto?.Invoke(this, EventArgs.Empty); };

            btnSalvar.Click += delegate { salvarProduto?.Invoke(this, EventArgs.Empty); };

            txtId.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    carregarProduto?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler salvarProduto;
        public event EventHandler excluirProduto;
        public event EventHandler novoProduto;
        public event EventHandler carregarProduto;

        public void SetListaGridProdutos(BindingSource lista)
        {
            gridProdutos.DataSource = lista;
        }

        public void LimparView()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "txtId")
                    ctrl.Text = "";
            }
        }

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //(Produto)gridProdutos.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
