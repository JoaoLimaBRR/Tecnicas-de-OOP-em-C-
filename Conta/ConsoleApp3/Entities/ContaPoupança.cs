using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entities
{
    class ContaPoupança : Conta
    {
        public double TaxaJuros{ get; set; }

        public ContaPoupança()
        {

        }

        public ContaPoupança(int numero, string nome, double saldo, double taxaJuros): base(numero, nome, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
