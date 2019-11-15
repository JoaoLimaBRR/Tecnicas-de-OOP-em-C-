using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entidades
{
    class Produto
    {
        //Criado dois atributos para receber o nome e o preco do produto
        //digitados nas linhas 33 e 35 da Class Program
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor vazio padrão
        public Produto()
        {

        }
        //Construtor recendo parametos capturados nas linhas 33 e 35
        // e instanciados na linha 36 da class Program
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}
