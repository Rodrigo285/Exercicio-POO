using Exercicio1;
using System;
using System.Globalization;
/*
 Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
 válidas).Em seguida,mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
 possui a maior área. 
 */

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {


            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X ");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y ");
            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine($"Area de X {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay) {
                Console.WriteLine("Maoir area X");
            }
            else {
                Console.WriteLine("Maior area Y");
            }
        }//fim main
    }
}
