using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entidades
{
    class Cliente
    {

        //Criando atributos capturados nas linhas 17, 19 e 21 da Class Program
        public string ClienteNome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }


        //Construtor vazio
        public Cliente()
        {

        }
        //Construtor recendo atributos capturados nas linhas 17, 19 e 21 da Class Program
        public Cliente(string clienteNome, string email, DateTime datanasc)
        {
            ClienteNome = clienteNome;
            Email = email;
            DataNasc = datanasc;
        }


        //Fazendo ToString para printar na tela de forma mais facil
        public override string ToString()
        {
            return ClienteNome 
                + "("
                +DataNasc.ToString("dd/MM/yyyy")
                + ")"
                + " - "
                + Email;
        }

    }
}
