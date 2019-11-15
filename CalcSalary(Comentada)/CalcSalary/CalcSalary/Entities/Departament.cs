using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSalary.Entities
{
    class Departament
    {
        //Variaveis do tipo Departament 
        public string Name { get; set; }

        //Construtor padrão
        public Departament()
        {

        }

        //Contrutor recebendo como parametro uma variavel capturada em Program na linha 17
        public Departament(string deptName)
        {
            Name = deptName;
        }
    }
}
