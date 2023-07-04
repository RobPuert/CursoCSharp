using System;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao {
        public static void Executar() {
            string produto = "Notebook Gamer";
            string marca = "Dell";  // poderíamos usar var marca = "Dell"  já que estamos inicializando a variável junto com a declaração.
            double preco = 5800.00;

            Console.WriteLine("O " + produto + " da marca " 
                + marca + " custa " + preco + ".");         // sentenças de código podem ser divididas em várias linhas sem problema.

            Console.WriteLine("O {0} da marca {1} custa {2}.",
                produto, marca, preco);                     // Com interpolação fica bem mais elegante e também aceita sentença em várias linhas.

            Console.WriteLine($"A marca {marca} é legal!");   // Outra opção é usar o $ para fazer tipo uma f string de Python.
            
            Console.WriteLine($"1 + 1 = {1 + 1}!");     // Operações matemáticas também são aceitas no lugar da variável
        }
    }
}
