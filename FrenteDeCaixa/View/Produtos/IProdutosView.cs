namespace FrenteDeCaixa.View.Produtos
{
    internal interface IProdutosView
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Observacao { get; set; }
        decimal Venda { get; set; }
        decimal Custo { get; set; }
        decimal Estoque { get; set; }
    }
}
