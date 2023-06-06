namespace FrenteDeCaixa.View.Clientes
{
    internal interface IClienteView
    {
        int Id { get; set; }
        string Nome { get; set; }
        DateTime DataCadastro { get; set; }
        string Documento { get; set; }
        string? Email { get; set; }
    }
}
