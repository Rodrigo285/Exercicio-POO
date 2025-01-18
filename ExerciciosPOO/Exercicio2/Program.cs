using Exercicio2;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = byte.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade) {
                Console.WriteLine($"Pessoa mais velha {pessoa1.nome}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha {pessoa2.nome}");

            }
        }
    }
}

