using System;

namespace CursoCSharp.Fundamentos
{
    class Inferencia {
        public static void Executar() {
            var nome = "Rob"; //Isso funciona. O C# infere, deduz o tipo da variável pelo dado atribuido
            // nome = 123;  Mas ele continua não permitindo a troca de tipo de dado na mesma variável
            Console.WriteLine(nome);

            int idade;  //variável declarada
            idade = 30;  // variável inicializada
            Console.WriteLine(idade);

            int a;  //variável declarada
            a = 3;  // só inicializada sem mencionar o tipo de novo.

            int b = 2;  // variável declarada e inicializada

            Console.WriteLine(a+b);

            /*
            var idade;      Variável com tipo implícito obriga a inicializá-la imediatamente como na var nome
            idade = 32;
            Console.WriteLine(idade);
            */

        }
    }
}
