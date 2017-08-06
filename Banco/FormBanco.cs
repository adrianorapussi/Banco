using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Usuarios;

namespace Banco
{
    public partial class FormBanco : Form
    {
        //Dicionario para associar um numero de conta com a conta
        private Dictionary<int, Conta> contas = new Dictionary<int, Conta>();
        private Conta contaEscolhida;
        private static String TITULO_JANELA_ERRO = "Erro";
        private static String ARQUIVO_CONTAS = Environment.CurrentDirectory + "/contas.txt";

        public FormBanco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Random random = new Random();
                Cliente cliente = new Cliente("Cliente " + i);
                Conta conta = new ContaPoupanca(random.Next(1, 1000) * i, i * 1000, cliente);
                this.AdicionaConta(conta);
            }
            //this.criarArquivoContas();
        }

        private void depositarValor_Click(object sender, EventArgs e)
        {
            if (this.isContaNull(this.contaEscolhida))
            {
                return;
            }
            this.contaEscolhida.Depositar(this.convertToDouble(valorSobreConta.Text));
            saldoConta.Text = Convert.ToString(contaEscolhida.Saldo);
        }

        private void saqueConta_Click(object sender, EventArgs e)
        {
            if (this.isContaNull(this.contaEscolhida))
            {
                return;
            }
            this.contaEscolhida.Saca(this.convertToDouble(valorSobreConta.Text));
            saldoConta.Text = Convert.ToString(contaEscolhida.Saldo);
        }

        private void numeroConta_TextChanged(object sender, EventArgs e)
        {
            //Nada
        }

        private void labelTitularConta_Click(object sender, EventArgs e)
        {
            //Nada
        }

        private void buttonBuscarConta_Click(object sender, EventArgs e)
        {
            string numeroContaBuscaString = textBoxNumeroContaBuscar.Text;
            int numeroContaBusca = 0;
            try
            {
                numeroContaBusca = Convert.ToInt32(numeroContaBuscaString);
                if (numeroContaBusca <= 0) { throw new Exception(); }
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Número de conta inválido \n" + excecao.Message, TITULO_JANELA_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.contaEscolhida = this.contas[numeroContaBusca];
            if (this.contaEscolhida != null)
            {
                titularConta.Text = this.contaEscolhida.Titular.Nome;
                numeroConta.Text = Convert.ToString(this.contaEscolhida.Numero);
                saldoConta.Text = Convert.ToString(this.contaEscolhida.Saldo);
                comboBoxContaCadastrada.Text = this.contaEscolhida.Titular.Nome;
            }
            else
            {
                MessageBox.Show("Conta não encontrada.", TITULO_JANELA_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isContaNull(Conta conta)
        {
            if (conta == null)
            {
                MessageBox.Show("Selecione uma conta válida.", TITULO_JANELA_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        //Converte uma string para double, lançando exceção caso tenha erro
        private double convertToDouble(string valorString)
        {
            double valor = 0.0;
            try
            {
                valor = Convert.ToInt32(valorString);
                if (valor <= 0) { throw new Exception(); }
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Valor inválido \n" + excecao.Message, TITULO_JANELA_ERRO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeTitular = (string)comboBoxContaCadastrada.SelectedItem;
            this.contaEscolhida = this.getContaByName(nomeTitular);
            if (this.isContaNull(this.contaEscolhida))
            {
                return;
            }
            textBoxNumeroContaBuscar.Text = Convert.ToString(this.contaEscolhida.Numero);
            titularConta.Text = this.contaEscolhida.Titular.Nome;
            numeroConta.Text = Convert.ToString(this.contaEscolhida.Numero);
            saldoConta.Text = Convert.ToString(this.contaEscolhida.Saldo);

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta.Numero, conta);
            comboBoxContaCadastrada.Items.Add(conta.Titular.Nome);

        }

        private void buttonNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formCadastroConta = new FormCadastroConta(this);
            formCadastroConta.ShowDialog();
        }

        private Conta getContaByName(String nome)
        {
            //Usando sintaxe de SQL
            var contaValue = from c in contas where c.Value.Titular.Nome == nome orderby c.Value.Titular descending, c.Value.Numero select c;
            //Usando lambda
            var contaKey = contas.Where(c => c.Value.Titular.Nome == nome);
            return contaKey.First().Value;
        }

        private void criarArquivoContas()
        {
            System.IO.File.Create(ARQUIVO_CONTAS);
            System.IO.Stream saida = System.IO.File.Open(ARQUIVO_CONTAS, System.IO.FileMode.Create);
            System.IO.StreamWriter escritor = new System.IO.StreamWriter(saida);
            for (int i = 1; i <= 5; i++)
            {
                Random random = new Random();
                Cliente cliente = new Cliente("Cliente " + i);
                Conta conta = new ContaPoupanca(random.Next(1, 1000) * i, i * 1000, cliente);
                escritor.WriteLine("Numero da conta: "+conta.Numero+", saldo da conta: "+conta.Saldo+",nome do titular da conta: "+conta.Titular.Nome);
                this.AdicionaConta(conta);
            }
            escritor.Close();
            saida.Close();
        }
    }
}
