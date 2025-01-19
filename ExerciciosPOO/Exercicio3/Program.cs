using Exercicio3;
using System;
using System.Globalization;


namespace Exercicio3 {
    internal class Program {
        static void Main(string[] args) {
            
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();  
            
            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();   
            Console.Write("Salario: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salario Medio = {func1.salarioMedio(func1.salario, func2.salario).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}