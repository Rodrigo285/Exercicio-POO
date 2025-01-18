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

            float xa, xb, xc, ya, yb, yc;

            Console.WriteLine("Entre com as medidas do triangulo X ");
            xa = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y ");
            ya = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float p = (xa + xb + xc) / 2;
            double areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2;
            double areay = Math.Sqrt(p * (p -   ya) * (p - yb) * (p - yc));

            Console.WriteLine($"Area de X {areax.ToString("F4", CultureInfo.InvariantCulture) }");
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