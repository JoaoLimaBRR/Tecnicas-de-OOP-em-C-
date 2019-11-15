using System;
using ConsoleApp3.Entities;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Alex", 0.0);
            ContaEmpresarial bacc = new ContaEmpresarial(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Conta acc1 = bacc;
            Conta acc2 = new ContaEmpresarial(1003, "Bob", 0.0, 200.00);
            Conta acc3 = new ContaPoupança(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING 

            ContaEmpresarial acc4 = (ContaEmpresarial)acc2;
            acc4.Emprestimo(100.0);
            

        }
    }
}
