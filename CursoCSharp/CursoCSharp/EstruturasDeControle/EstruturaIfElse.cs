using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse {
        public static void Executar() {
            double nota = 7.0;

            if (nota >= 7.0) {                              // aqui é obrigatório a chave porque tem mais de uma sentença de código
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação");           //aqui poderia tirar as chaves porque só tem uma sentença de código.
            }
        }
    }
}
