using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);             // Sorteará um número aleatório entre 1 e 15 (16 não será incluído)
            bool numeroEncontrado = false;                  // não precisaria inicializar a variável numeroEncontrado como false porque false já é o padrão de início, mas ela ainda precisaria ser inicializada antes de alguma validação
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Tente um número menor!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                } else {
                    Console.WriteLine("Tente um número maior!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }
        }
    }
}
