using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile {
        public static void Executar() {
            /* Enquanto o while tem chance de nunca ser executado caso a expressão nunca seja true, o Do while sempre executará o bloco de código
             * do "Do" pelo menos uma vez.  Do While é a única estrutura de repetição em C# que exige chaves e é a única em que o bloco de código
             * vem antes da expressão. */

            string entrada;
            do {
                Console.WriteLine("Qual é o seu nome?");            //Pelo menos uma vez vai perguntar o nome
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");                     // padroniza para minúsculo e compara se o digitado foi s mesmo.
                                                                    // enquanto a pessoa digitar s, vai inserir nomes (a partir do segundo nome)
        }
    }
}
