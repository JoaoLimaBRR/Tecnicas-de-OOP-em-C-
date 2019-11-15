using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSalary.Entities
{
    class HourContract
    {
            //Variaveis do tipo HourContract
             public DateTime Date { get; set; }
            public double ValuePerHour { get; set; }
            public int Hours { get; set; }

           //construtor padrão
            public HourContract()
            {
            }
          //Construtor recendo parametros capturados em Program na linha 50, 53, 56
            public HourContract(DateTime date, double valuePerHour, int hours)
            {
                Date = date;
                ValuePerHour = valuePerHour;
                Hours = hours;
            }
        //Função que return Hours * ValuePerHour
            public double TotalValue()
            {
                return Hours * ValuePerHour;
            }
        }
    }

