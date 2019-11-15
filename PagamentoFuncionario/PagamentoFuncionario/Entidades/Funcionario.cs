using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoFuncionario.Entidades
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public int Horas{ get; set; }
        public double ValorHora { get; set; }

        public double Pagamento{ get; protected set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
           
        }
    }
}
