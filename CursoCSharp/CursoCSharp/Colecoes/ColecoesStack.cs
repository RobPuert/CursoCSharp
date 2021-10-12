using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {                               //  Stack = Pilha / Último que entra / primeiro que sai
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);                              // Empurra um item para a pilha.  Coloca um item na pilha.
            pilha.Push('a');
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");     // Retira e exibe o último elemento que foi colocado na pilha  (\n quebra linha)

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");   // Mostra (Sem remover) o último item da pilha (o próximo a sair num possível pop)
            Console.WriteLine(pilha.Count);
        }
    }
}
