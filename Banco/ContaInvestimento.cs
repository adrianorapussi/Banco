using Banco.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {
        public ContaInvestimento() {}
        public ContaInvestimento(int numero, double saldo, Cliente titular) : base(numero, saldo, titular) { }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
