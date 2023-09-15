using System;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine($"Numeros pares entre 1 e {intervalo}!");

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;                       // diferente do break que quebra o laço, o continue manda executar a próxima repetição e "pula" a atual
                }                                   // nesse caso, sempre q encontra um nº ímpar o continue manda continuar p/ próx. repetição sem fazer nada.

                Console.Write(i + " ");
            }
        }
    }
}
