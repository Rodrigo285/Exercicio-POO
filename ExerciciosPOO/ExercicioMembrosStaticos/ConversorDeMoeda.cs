using System;
using System.Globalization;

namespace ExercicioMembrosStaticos {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double DollarParaReal(double cotacao, double quantia) {

            double total = cotacao * quantia;
            return total + total * Iof / 100.0;

        }

    }
}