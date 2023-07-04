using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;  //variável raio do tipo double recebe 4.5. Double é para números decimais como o float em python
            const double PI = 3.14;  //mesmo princípio para uma constante

            raio = 5.5;  //variável pode receber outra atribuição (do mesmo tipo) e não precisa repetir o tipo ao reatribuir um valor
            // PI = 3.1415    const não pode receber outra atribuição

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area); //Concatenação igual no Python

            //Tipos internos

            bool estaChovendo = true; // tipo booleano tradicional
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;  // tipo inteiro que armazena valores pequenos (não aceita negativo)
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;  //signed byte - é um byte que aceita negativo  
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;  //tipo inteiro até 32767
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado para inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // unsigned int - é um int que não aceita sinal de negativo
            Console.WriteLine("População Brasileira " + populacaoBrasileira); // os underscores acima podem servir como separador (opcional)

            long menorValorLong = long.MinValue;  // para números realmente gigantescos
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;  // unsigned long. long sem sinal
            Console.WriteLine("População Mundial " + populacaoMundial); // Esse valor não caberia no uint porque ele só vai até 4 bilhões

            float precoComputador = 1299.99f; // o float exige o f no final. Sem f é double. O f pode ser minúsculo ou maiúsculo
            Console.WriteLine("Preço Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado para nº real. Double cabe o dobro de bytes do float
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // usado para nº reais astronômicos
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; // apóstrofos só podem ser usados para uma letra sozinha
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem-vindo ao Curso de C#!"; // para strings tem que ser aspas
            Console.WriteLine(texto);
        }
    }
}
