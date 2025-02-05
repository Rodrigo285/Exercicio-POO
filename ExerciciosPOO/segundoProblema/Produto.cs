using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace segundoProblema {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValorTotalEstoque() {
            return Quantidade * Preco;
       }


        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        

    }
}
