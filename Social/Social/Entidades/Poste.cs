using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Social.Entidades
{
    class Poste
    {
        //Atributos da classe Poste
        public DateTime Momento{ get; set; }
        public string Titulo { get; set; }
        public string Contexto{ get; set; }
        public int Likes { get; set; }

        //Criando uma lista para receber diversos comentarios da relação 1 Poste Varios Comentarios do diagrama
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        //Construtor padrão 
        public Poste()
        {

        }


       //Construtor recendo parametros  
        public Poste(DateTime momento, string titulo, string contexto, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Contexto = contexto;
            Likes = likes;
        }


        //Metodo para adicionar um comentario a lista
        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        //Função para remover algum comentario da lista
        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }


        //StringBuilder quase a mesma função do Override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss" ));
            sb.AppendLine("Comentarios: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    } 
}
