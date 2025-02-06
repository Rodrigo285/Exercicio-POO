using System;
using System.Globalization;

namespace ExercicioFixacao3 {
     internal class Program {
        static void Main(string[] args) {

            Aluno aluno1 = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                    + aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            
            }


        }
    }
}