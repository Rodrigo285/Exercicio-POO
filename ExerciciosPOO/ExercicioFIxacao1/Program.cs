﻿using ExercicioFIxacao1;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine( );
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            retangulo.Altura = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture) );
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
           

            


        }
    }
}