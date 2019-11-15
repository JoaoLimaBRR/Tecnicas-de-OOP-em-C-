using CalcSalary.Entities.Enums;
using System.Collections.Generic;

namespace CalcSalary.Entities
{
    class Worker
    {
        //Variaveis do tipo WORKER
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Department { get; set; }

        //Lista para adicionar a quantidade de contratos
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        //Construtor padrão
        public Worker()
        {
        }

        //Contrutor passando parametros
        public Worker(string name, WorkerLevel level, double baseSalary, Departament department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = new List<HourContract>();
        }

        //Função para adicionar dados a lista instancia na linha 15 
        //Passando como parametro dados capturados e instanciados em Program na linha 60
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //Função para remover dados da lista instancia na linha 15
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Função para fazer o calculo recebendo como parametros variaveis year & month 
        //Capturadas nas linhas 76 e 80 
        public double Income(int year, int month)
        {
            // Fazendo a variavel sum receber o valor de BaseSalary
            double sum = BaseSalary;
            //Fazendo um foreach para percorrer toda a lista 
            foreach (HourContract contract in Contracts)
            {
                //Date.Year captura o ano inserido na variavel date em Program linha 50
                //Date.Month captura o mes inserido na variavel date em Program linha 50
                //Verificando se existe algum ano igual ao ano capturado na substring em Program linha 80
                //Verificando se existe algum mes igual ao ano capturado na substring em Program linha 76
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    //se existe a viariavel sum recebe o valor total 
                    //recendo contract."TotalValue" (Função de calculo em HourContract)
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
