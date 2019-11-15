using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Entidades;
using Pedidos.Entidades.Enums;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Capturando dados e instanciando para a Claas Cliente na linha 23
                Console.WriteLine("Entre com os dados do cliente");
                Console.Write("Nome: ");
                string clienteNome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Data de Nascimento: ");
                DateTime datanasc = DateTime.Parse(Console.ReadLine());
                Cliente cliente = new Cliente(clienteNome, email, datanasc);

                //Capturando dados e instaciando para a Class Pedido na linha 29
                Console.WriteLine("Entre com os dados do pedido EX: \nPagamento_Pendente"+
            "Processando\nEnviado\nEntregue");
                Console.Write("Status: ");
                StatusPedidos status = (StatusPedidos)Enum.Parse(typeof(StatusPedidos), (Console.ReadLine()));
                Pedido pedido = new Pedido(DateTime.Now, status, cliente);

                //Perguntando quantos itens foram adquiridos para fazer o cadastro
                Console.Write("Quantos itens foi comprado ? ");
                int loop = int.Parse(Console.ReadLine());
                //FOR para percorrrer e capturar os dados dos itens comprados
                for (int i = 1; i <= loop; i++)
                {
                    //Capturando dados e instanciando para a Class Produto na linha 43
                    Console.WriteLine("Digite os dados do produto #" + i);
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Produto produto = new Produto(nome, preco);

                    //Capturando dados e instanciando para a Class ItemPedido na linha 49
                    Console.Write("Quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    ItemPedido itemPedido = new ItemPedido(quantidade, preco, produto);

                    //Adicionando um pedido a lista
                    pedido.AddPedido(itemPedido);



                }
                Console.WriteLine("SUMARIO DO ITEM: ");
                Console.WriteLine(pedido);

            }catch(System.ArgumentException )
            {
                Console.WriteLine("Incersao Incorreta");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Incersao Incorreta");
            }
        }
    }
}
