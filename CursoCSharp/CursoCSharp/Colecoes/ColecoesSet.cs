using System;
using System.Collections.Generic;           
using System.Text;

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto(" Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();             // HashSet não é indexado
            carrinho.Add(livro);                           

            var combo = new HashSet<Produto> {                 // Definimos aqui uma Lista com 3 produtos
                new Produto(" Camisa", 29.9),
                new Produto(" 8ª Temporada Game of Thrones", 99.9),
                new Produto(" Poster", 10)
            };

            carrinho.UnionWith(combo);                       // Set trabalha com conjuntos. Então usamos o método union para unir os conjuntos carrinho e combo
            Console.WriteLine(carrinho.Count);              // Dirá quantos elementos possui o carrinho
            // carrinho.RemoveAt(3);                           // HashSet não é indexado então não dá pra fazer isso

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item));       // HashSet não é indexado então não dá pra fazer isso
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);                                    // Set não aceita repetição. Não dá pra add um livro repetido à lista. Não dá erro. Ele ignora
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));      // HashSet não é indexado então não dá pra fazer isso
        }
    }
}
