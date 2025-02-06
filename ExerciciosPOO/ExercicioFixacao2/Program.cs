using System;
using System.Globalization;

namespace ExercicioFixacao2 {
     class Program {
        static void Main(string[] args) {

            Funcionario funcionario1 = new Funcionario();
            
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario1);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            funcionario1.AumentarSalario(porcent);
                
            Console.WriteLine("Dados atualizados: " + funcionario1);

        }
    }
    
}