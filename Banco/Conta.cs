using Banco.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public Conta() {}
        public Conta(int numero, double saldo, Cliente titular)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.Titular = titular;
        }

        public void Depositar(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }
}
