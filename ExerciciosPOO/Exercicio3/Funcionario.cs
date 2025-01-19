using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Exercicio3 {
    internal class Funcionario {

        public string nome;
        public double salario = 0;

        public double salarioMedio(double salario1, double salario2) {

            return (salario1 + salario2) / 2;
        }
    }
}
