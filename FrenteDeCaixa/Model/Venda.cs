using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Model
{
    internal class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public decimal Total { get; set; } = 0.00m;
        List<Extrato> Extratos { get; set; }
        public Venda()
        {
            Extratos = new List<Extrato>();
        }
    }
}
