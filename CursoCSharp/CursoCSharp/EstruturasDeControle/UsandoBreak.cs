using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);        // gerando número aleatório entre 1 e 50 (51 não é incluído)

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine($"{i} é o número que queremos?");
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;                          // Sem o break ele responderia Sim quando achasse o número mais continuaria percorrendo o for até o 50
                } else {                            // O break quebra o laço (for), não o if
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
