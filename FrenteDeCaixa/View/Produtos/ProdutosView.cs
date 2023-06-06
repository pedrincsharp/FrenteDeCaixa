using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteDeCaixa.View.Produtos
{
    public partial class ProdutosView : Form, IProdutosView
    {
        public ProdutosView()
        {
            InitializeComponent();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Observacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Venda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Custo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Estoque { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
