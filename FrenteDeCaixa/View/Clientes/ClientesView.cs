using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteDeCaixa.View.Clientes
{
    public partial class ClientesView : Form, IClienteView
    {
        public ClientesView()
        {
            InitializeComponent();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataCadastro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Documento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
