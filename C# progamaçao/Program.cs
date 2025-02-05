namespace C__progamaçao {
    using System;
    using System.Globalization;
    internal class Program {
        public static IFormatProvider? F2 { get; private set; }

        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("produtos:" );
            Console.WriteLine($"{produto1} com o valor de { preco1}" );
            Console.WriteLine($"{produto2} com o valor de {preco2.ToString( CultureInfo.InvariantCulture)}");
            Console.Write("Registro:" );
            Console.WriteLine( $"{idade} de idade, {codigo} e genero {genero}");
            Console.WriteLine( $"a medida e {medida:F8}");
            Console.WriteLine($"a media e {medida.ToString(CultureInfo.InvariantCulture)}" );

        
        
        
        
        
        
        
        
        
        
        }
    }

}

        
    

