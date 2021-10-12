using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));   //Transf em string e arredonda para 1 casa decimal.   15,2  (imprime vírgula pq meu windows é PTBR)
            Console.WriteLine(valor.ToString("C"));    //Transf em string e usa o critério C para transformar numa currency (moeda) (imprime em reais porque meu windows é PTBR) padrão 2 casas decimais
            Console.WriteLine(valor.ToString("P"));    //Transf em string, multiplica por 100 e adiciona o sinal de procentagem
            Console.WriteLine(valor.ToString("#.##")); //Transf em string e formata para duas casas decimais (nesse caso como o F2 faria)

            CultureInfo cultura = new CultureInfo("en-US");   //Amarra as configurações de en-US ao código que usar essa variável
            Console.WriteLine(valor.ToString("C3", cultura)); //Transf em string, pede formatação de currency com 3 casas decimais e usa a info da variável cultura q foi definida antes $ 15.175

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));   //Transf em string e COMPLETA com zeros à esquerda até dar 10 dígitos. Por padrão ignora zeros à esquerda
        }
    }
}
