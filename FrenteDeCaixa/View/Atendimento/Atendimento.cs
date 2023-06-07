using FrenteDeCaixa.Model;
using FrenteDeCaixa.View.Atendimento;
using FrenteDeCaixa.View.Produtos;

namespace FrenteDeCaixa
{
    public partial class Atendimento : Form, IAtendimento
    {
        public Atendimento()
        {
            InitializeComponent();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdCliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProdutosView().ShowDialog();
        }
    }
}