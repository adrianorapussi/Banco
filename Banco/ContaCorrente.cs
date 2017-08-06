using Banco.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente()
        {

        }
        public ContaCorrente(int numero, double saldo, Cliente titular) : base(numero, saldo, titular) { }

        public override void Saca(double valorOperacao)
        {
            base.Saca(valorOperacao);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.01;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ContaCorrente))
            {
                return false;
            }
            ContaCorrente contaCorrenteOutra = (ContaCorrente)obj;
            return this.Numero == contaCorrenteOutra.Numero //
                && this.Saldo == contaCorrenteOutra.Saldo //
                && this.Titular == contaCorrenteOutra.Titular;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
