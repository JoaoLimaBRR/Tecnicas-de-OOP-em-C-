using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entidades
{
    class ItemPedido
    {
        //Criando atributos capturados nas linhas 39, 35 e 36
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto Produto { get; set; }



        //Construtor vazio
        public ItemPedido()
        {

        }


        //Construtor recebendo parametros capturados nas linhas 39, 35 e 36
        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }


        //Metodo para fazer o SubTotal de cada pedido
        //OBS: Existe um metodo Total() que apenas soma estes SubTotais trazendo o total da compra
        public double SubTotal()
        {
             return Quantidade * Preco;
        }

        //ToString para printar na tela de forma mais simples
        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Produto.Preco
                + ", "
                + "Quantidade: "
                + Quantidade
                +", Subtotal: $"
                + SubTotal();
        }
    }
}
