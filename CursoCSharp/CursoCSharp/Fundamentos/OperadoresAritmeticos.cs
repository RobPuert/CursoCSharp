using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;     // Pela inicialização da variável o compilador infere que a mesma é do tipo double
            var imposto = 355;      // Pela inicialização da variável o compilador infere que a mesma é do tipo int
            var desconto = 0.1;     //10% de desconto

            double total = preco + imposto;     // soma de double com inteiro pode ser armazenado em um double mas não em um int
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto}");

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);   // altura ao quadrado
            Console.WriteLine("O IMC é {0}", imc);

            // Número Par / Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);        //  24 /2 por 2 tem resto  0
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);    // 55 /2 tem resto 1
        }
    }
}
