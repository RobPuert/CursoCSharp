using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;                      // operador pós fixado, nesse caso o ++ poderia estar antes do nome da variável tbm
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);     // operador pré-fixado, nesse caso o -- poderia estar depois do nome da variável tbm

            Console.WriteLine(numero1++ == --numero2);  //  (Evite isso porque é confuso) - Usar o pós-fixado significa menos pressa,
                                                        //  então o pré-fixado será resolvido primeiro. Logo o numero2 será decrementado antes do incremento do numero1

            Console.WriteLine($"{numero1} {numero2 }");
        }
    }
}
