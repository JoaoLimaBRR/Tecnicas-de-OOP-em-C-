using System;
using Social.Entidades;

namespace Social
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando comentarios a lista
            Comentario c1 = new Comentario("Boa viagem");
            Comentario c2 = new Comentario("Vai com Deus");

            //Instanciando um Poste passando os parametros pedidos pelo construtor
            Poste p1 = new Poste(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viagem para Nova Zelandia",
                "Eu estou viajando com minha familia",
                12);

            //Adicionando o comenatrio c1 & c2 ao Poste p1
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            //Instanciando comentarios a lista
            Comentario c3 = new Comentario("Mande lembranças a familia");
            Comentario c4 = new Comentario("Volta quando ?");

            //Instanciando um Poste passando os parametros pedidos pelo construtor
            Poste p2 = new Poste(
                DateTime.Parse("25/02/2000 16:37:18"),
                "Indo ver minha mãe",
                "Indo visitar minha familia no interior",
                18);
            //Adicionando o comenatrio c3 & c4 ao Poste p2
            p2.AddComentario(c3);
            p2.AddComentario(c4);



            //Mostrando na tela pela função do StringBuilder a publicação formatada no mesmo padrão que mostra lá na função
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }

    }
}
