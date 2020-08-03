\\ Cálculo de salário de funcionário, usando aumento baseado em porcentagem

using System;
using System.Globalization;

namespace Calculo_salário__POO_

{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double a)
        {
            SalarioBruto = SalarioBruto + (a / 100.0) * SalarioBruto;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + 
                "\n Salário Bruto: " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture) + 
                "\n Imposto: " + Imposto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Globalization;

namespace Calculo_salário__POO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario X = new Funcionario();
            Console.WriteLine("Digite o nome do funcionário: ");
            X.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário: ");
            X.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de imposto sobre o salário: ");
            X.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(X.ToString());
            Console.WriteLine("Digite a porcentagem para aumentar o salário : ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.AumentarSalario(p);
            Console.WriteLine("Dados Atualizados: " + X.Nome + ", $ " + X.SalarioLiquido());



        }
    }
}
