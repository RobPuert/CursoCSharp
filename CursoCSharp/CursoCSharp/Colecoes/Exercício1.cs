using System;

namespace CursoCSharp.Colecoes {
    class Exercício1 {
        public static void Executar() {
            // Média de idades
            int[] idades = new int[5];
            for (int i = 0; i < idades.Length; i++) {
                Console.Write("Digite a idade do aluno: ");
                int.TryParse(Console.ReadLine(), out idades[i]);
            }
            var media = 0;
            foreach (int idade in idades) {
                media += idade;
            }
            Console.WriteLine($"A média de idade da turma é: {(double)media / idades.Length}");

            // Par ou ímpar
            Console.Write("Digite um número para saber se este é par ou ímpar: ");
            int.TryParse(Console.ReadLine(), out int numero);

            if (numero % 2 == 0) {
                Console.WriteLine($"{numero} é par!");
            } else {
                Console.WriteLine($"{numero} é ímpar!");
            }
        }
        }
    }
