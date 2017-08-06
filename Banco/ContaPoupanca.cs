using Banco.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca() { }
        public ContaPoupanca(int numero, double saldo, Cliente titular) : base(numero, saldo, titular) { }

        public override void Saca(double valorOperacao)
        {
            base.Saca(valorOperacao + 10);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
