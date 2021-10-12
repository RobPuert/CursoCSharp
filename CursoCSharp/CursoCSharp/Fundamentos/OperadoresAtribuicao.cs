using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;                   // substituiu o 3 por 7
            num1 += 10;                 // incrementou a variável num1 em 10 como no Python
            num1 -= 3;                  // decrementou a variável num1 em 3 como no Python
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;                  // está copiando o valor de a para b

            a++;                        // incrementou a em 1
            b--;                        // decrementou b em 1

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;              //usando o dynamic, d receberá c mas ambos utilizarão o mesmo espaço de memória. Logo alterar d, altera c.
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
