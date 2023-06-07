using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Model
{
    internal class Extrato
    {
        public int Id { get; set; } 
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public decimal Quantidade { get; set; } = 0.00m;
        public decimal Valor { get; set; } = 0.00m;
    }
}
