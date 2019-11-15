using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Entidades.Enums;
using System.Globalization;

namespace Pedidos.Entidades
{
    class Pedido
    {

        //Criado atributos para receber o momento exato da compra capturado pelo sistema
        public DateTime Momento { get; set; }

        // Status do pedido que vem de uma outra UNUMS
        public StatusPedidos Status { get; set; }

        //Cliente que passa todos os dados capturados na Classe cliente
        public Cliente Cliente { get; set; }

        //Fazendo uma liste do tipo ItemPedido que por sua vez possui atributos como Quantida, Preco e Produto"Que tambem e outra classe"
        public List<ItemPedido> List_Pedidos { get; set; } = new List<ItemPedido>();


        //Construtor Vazio
        public Pedido()
        {

        }


       //Contrutor recebendo parametros capturados nas linhas 26
       //Momento e capturado pelo DateTime.Now que traz o momento que o sistema recebeu os dados
       // StatusPedidos do tipo ENUMS que vem de outra Class
       //E Cliente que é uma Class passando seus parametros
        public Pedido(DateTime momento, StatusPedidos status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }


        //Adicionando um pedido a lista 
        public void AddPedido(ItemPedido pedido)
        {
            List_Pedidos.Add(pedido);
        }


        //Removendo um pedido da lista
        public void RemoverPedido(ItemPedido pedido)
        {
            List_Pedidos.Remove(pedido);
        }

        //Percorrendo toda a lista atraves do FOREACH e somando Todos os SubTotais capturados um metodo na Class ItemPedido
        public double Total()
        {
            double soma = 0.0;
            foreach(ItemPedido total in List_Pedidos)
            {
                soma += total.SubTotal();
            }
            return soma;
        }

        //Fazendo um StringBuilder para printar na tela as informações 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Momento do pedido: ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss" ));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Pedidos: ");

            //Percorredo toda a lista e transformando tudo em string
            foreach (ItemPedido ped in List_Pedidos)
            {
                sb.AppendLine(ped.ToString());
            }
            sb.AppendLine("Preço total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
