using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

    }
}
