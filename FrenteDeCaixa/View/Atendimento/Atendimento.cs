using FrenteDeCaixa.Model;
using FrenteDeCaixa.View.Atendimento;

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
        Cliente IAtendimento.Cliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Produto IAtendimento.Produto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}