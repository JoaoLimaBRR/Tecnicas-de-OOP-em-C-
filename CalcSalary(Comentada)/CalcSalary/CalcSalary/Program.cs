using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcSalary.Entities.Enums;
using CalcSalary.Entities;
using System.Globalization;
namespace CalcSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados com o nome do departamento e guardando na viriavel "deptName"
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            //Pedindo os dados do trabalhador 
            Console.WriteLine("Enter worker data: ");
           //Pedindo o nome do trabalhador e guardando na viriavel "name"
            Console.Write("Name: ");
            string name = Console.ReadLine();
            //Perguntando o nivel do funcionario e guardando na variavel "level" do tipo enumerado "WorkLevel"
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = new WorkerLevel();
            Enum.TryParse(Console.ReadLine(), out level);
            //Pedindo o salario mensal do colaborador e guardando na variavel "baseSalary"
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando um nome objeto do tipo Departamento dept e passando para ele
            //a variavel auxiliar capturada na linha 17
            Departament dept = new Departament(deptName);

            //Instanciando um nome objeto do tipo Worker "worker" passando para ele
            //as variaveis auxiliares capturadas na linhas 22, 25, 29
            // e passando tambem o um dept objeto instanciado acima na linha 33
            Worker worker = new Worker(name, level, baseSalary, dept);

            //Pedindo a quantidade e contratos e guardando na variavel n
            Console.WriteLine("How many contracts to this worker ?");
            int n = int.Parse(Console.ReadLine());
            //FOR para pedir os dados do contrato 
            for (int i = 1; i <= n; i++)
            {
                //Pedindo os dados 
                Console.WriteLine("Enter #" + i + "contract data ");
                Console.Write("Date (DD/MM/YYYY): ");
                //Guardando a data digitada na variavel date
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                //Guardando o valor da hora trabalhada digitada na variavel valuePerHours
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duraction (hours)");
                //Capturando quantas horas trabalhadas foi digitada e guardando na variavel hours
                int hours = int.Parse(Console.ReadLine());

                //Instanciando um objeto contract e passando os paramentros capturados na linha 
                //50, 53, 56
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Passando os dados colocados no contract para um função na classe WORKER
                //que adiciona os dados a uma lista
                worker.AddContract(contract);
            } 

            Console.WriteLine();

            //Pedindo o mes e ano que deve ser calculado e guardando na variavel monthAndYear
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            
            //Pegando as 2 primeiras posições da variavel capturada acima
           //"02"/2018
           //Pegando da casa 0 até a 2
            int month = int.Parse(monthAndYear.Substring(0, 2));
            //Pegando as 4 ultimas posições da variavel capturada acima
            //02/"2018"
            //Pegando da casa 3 em diante 
            int year = int.Parse(monthAndYear.Substring(3));

            //Printando os dados na tela
            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Departament " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));





        }
    }
}
