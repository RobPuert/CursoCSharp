using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();         // Criando fila só de strings. Queue que usa System.Collections.Generic; e só aceita um tipo por vez

            fila.Enqueue("Fulano");                 // Enfileirando
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");               // Filas aceitam repetição de itens

            Console.WriteLine(fila.Peek());           // Pega (sem remover) o primeiro elemento da fila. "O primeiro q será atendido"
            Console.WriteLine(fila.Count);           // o atributo count é para Coleções o que o Length é para Arrays.  Conta quantos elementos tem

            Console.WriteLine(fila.Dequeue());        // Desenfileira. Tira o primeiro da fila. "O primeiro é antendido"
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();                 // Queue que usa System.Collections; e aceita vários tipos por vez
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));     // Pesquisa se o item está na fila. Cuidado! É case sensitive
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
