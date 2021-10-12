using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {

            /*  Com while:
            
            int i = 1;

            while(i <= 10) {
                Console.WriteLine($"O valor de i é {i}.");              // Priorize o while para laços que serão repetidos por um nº indeterminado de vezes
                i++;
            
            Com for:

            for(int i = 1; i <= 10; i++) {
                    Console.WriteLine($"O valor de i é {i}.");          // Priorize o for para laços que serão repetidos por um nº determinado de vezes
                } */

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;     // se o tamanho da turma for 0, media recebe somatorio / tamanho da turma, senão recebe 0
            Console.WriteLine("Media da turma: {0}", media);
        }
    }
}
