using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaXPTO.Entidades;

namespace LojaXPTO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
            Console.Write("Quantos produtos sera cadastrado: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto #" + i);
                Console.Write("Tipo de produto (c/u/i)");
                char aux = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                if(aux == 'i')
                {
                    Console.Write("Frete: ");
                    double custoFrete = double.Parse(Console.ReadLine());
                    Produtos.Add (new ProdutoImportado(nome, preco, custoFrete));
                }
                else if (aux == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY)");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    Produtos.Add(new ProdutoUsado(nome, preco, fabricacao));
                }

            }
        }
    }
}
