using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);       // Criando produto usando a class Produto de outro exercício nessa pasta. Nome Caneta, preço 1,89
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;                                // Atribuição de memória por referência. Ambas variáveis apontam para o mesmo espaço de memória

            Console.WriteLine(p1 == p2);                // False pq está comparando referência de memória e essas duas variáveis apontam para locais de memória diferentes.
            Console.WriteLine(p2 == p3);                // True pq ambas variáveis apontam para o mesmo espaço de memória

            Console.WriteLine(p1.Equals(p2));           // Método para comparar variáveis. Por padrão, ele também compara endereço de memória. Mexemos no método Equals da                                                  classe Produto (em ColecoesList) para o Equals comparar nome e preço do objeto e ver se realmente são iguais.


        }
    }
}
