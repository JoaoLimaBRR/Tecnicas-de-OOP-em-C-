using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Entidades
{
    class Comentario
    {
        // Criando um atributo Texto para receber o texto dos comenatios 
        public string Texto { get; set; }

        //Construtor vazio padrão
        public Comentario()
        {

        }

        // Construtor recebem um parametos de entrada
        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
