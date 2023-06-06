using System.ComponentModel.DataAnnotations;

namespace FrenteDeCaixa.Model
{
    internal class Cliente
    {
        [Display(Name = "Id")]
        public int Id { get; set; } = 1;
        [Display(Name = "Cliente")]
        public string Nome { get; set; } = "";
        [Display(Name = "Data de cadastro")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Documento")]
        public string Documento { get; set; } = "";
        [Display(Name = "E-mail")]
        public string? Email { get; set; }
    }
}
