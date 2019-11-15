using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entities
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {

        }

        public ContaEmpresarial( int numero, string nome, double saldo, double limiteEmprestimo) 
            : base(numero, nome, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
