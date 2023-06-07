using FrenteDeCaixa.Model;
using FrenteDeCaixa.Repository;
using FrenteDeCaixa.View.Produtos;

namespace FrenteDeCaixa.Presenter
{
    internal class ProdutosPresenter
    {
        private IProdutosView _view;
        private ProdutoRepo _repository;
        private BindingSource _produtosSource;
        private List<Produto> _produtos;

        public ProdutosPresenter(IProdutosView view)
        {
            _view = view;
            _repository = new ProdutoRepo();
            _produtosSource = new BindingSource();
            _produtos = new List<Produto>();

            this._view.SetListaGridProdutos(_produtosSource);

            this._view.salvarProduto += _view_salvarProduto;
            this._view.excluirProduto += _view_excluirProduto;
            this._view.novoProduto += _view_novoProduto;
            this._view.carregarProduto += _view_carregarProduto;

            CarregarListaProdutos(true);
        }

        private void CarregarListaProdutos(bool novo = false)
        {
            _produtos = _repository.GetAll();
            _produtosSource.DataSource = _produtos;
            if (novo)
            {
                this._view.LimparView();
                this._view.Id = _produtos.Max<Produto>(x => x.Id) + 1;
            }
        }

        private void _view_carregarProduto(object? sender, EventArgs e)
        {
            CarregarListaProdutos();

            IEnumerable<Produto> query = _produtos.Where(x => x.Id == this._view.Id);
            if (query.Count() == 0 || query == null)
            {
                CarregarListaProdutos(true);
                return;
            }

            Produto prod = query.First();

            this._view.Nome = prod.Nome;
            this._view.Observacao = prod.Observacao;
            this._view.Venda = prod.Venda;
            this._view.Custo = prod.Custo;
            this._view.Estoque = prod.Estoque;
        }

        private void _view_novoProduto(object? sender, EventArgs e)
        {
            CarregarListaProdutos(true);
            this._view.LimparView();
        }

        private void _view_excluirProduto(object? sender, EventArgs e)
        {
            CarregarListaProdutos();
            IEnumerable<Produto> query = _produtos.Where(x => x.Id == this._view.Id);
            if (query.Count() == 0 || query == null)
                return;

            _repository.Delete(this._view.Id);

            MessageBox.Show("Registro excluido com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarListaProdutos(true);
        }

        private void _view_salvarProduto(object? sender, EventArgs e)
        {
            CarregarListaProdutos();
            IEnumerable<Produto> query = _produtos.Where(x => x.Id == this._view.Id);

            Produto produto = new Produto()
            {
                Id = this._view.Id,
                Nome = this._view.Nome,
                Observacao = this._view.Observacao,
                Venda = this._view.Venda,
                Custo = this._view.Custo,
                Estoque = this._view.Estoque
            };

            if (query.Count() == 0 || query == null)
            {
                _repository.Insert(produto);
            }
            else
            {
                _repository.Update(produto);
            }
            MessageBox.Show("Registro salvo com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarListaProdutos(true);
        }
    }
}
