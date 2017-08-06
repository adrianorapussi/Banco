using Banco.Usuarios;
using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {

        private FormBanco formPrincipal;

        public FormCadastroConta(FormBanco formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            string nomeNovoCliente = textBoxNomeCadastroConta.Text;
            Cliente novoCliente = new Cliente(nomeNovoCliente);
            Random random = new Random();
            Conta novaConta = new ContaCorrente(random.Next(1,1000),0,novoCliente);
            this.formPrincipal.AdicionaConta(novaConta);
            this.Close();
        }
    }
}
