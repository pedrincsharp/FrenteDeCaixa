using System.ComponentModel.DataAnnotations;

namespace FrenteDeCaixa.Model
{
    internal class Produto
    {
        [Display(Name = "Id")]
        public int Id { get; set; } = 1;
        [Display(Name = "Produto")]
        public string Nome { get; set; } = "";
        [Display(Name = "Observação")]
        public string Observacao { get; set; } = "";
        [Display(Name = "Valor de venda")]
        public decimal Venda { get; set; } = 0.00m;
        [Display(Name = "Valor de custo")]
        public decimal Custo { get; set; } = 0.00m;
        [Display(Name = "Quantidade em estoque")]
        public decimal Estoque { get; set; } = 0.00m;
    }
}
