using FrenteDeCaixa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.View.Atendimento
{
    internal interface IAtendimento
    {
        int Id { get; set; }
        int IdCliente { get; set; }
        decimal Total { get; set; }
    }
}
