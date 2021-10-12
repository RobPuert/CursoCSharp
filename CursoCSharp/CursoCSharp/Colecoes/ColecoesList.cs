using System;
using System.Collections.Generic;           // List<Generic> Só está disponível aqui. Serve para listas de um único tipo definido na inicialização.
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {                   // Função que altera o método Equals para comparar nome e preço e saber se os produtos sãod e fato iguais
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }
        public override int GetHashCode() {                  // HashCode vai pegar o length dos obj para comparar. Você pode, por exemplo filtrar nomes usando o hascode
            return Nome.Length;                              // "cortando" a lista e depois usa o equals para comprar se os que sobraram são 100% iguais ou não.
        }
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto(" Game of Thrones", 49.9);

            var carrinho = new List<Produto>();             // Array List que só armazenará Objetos da Classe Produto. List é dinâmica e pode ter add (append no Python)
            carrinho.Add(livro);                           // adicionando item à lista          /       Listas também são indexadas

            var combo = new List<Produto> {                 // Definimos aqui uma Lista com 3 produtos
                new Produto(" Camisa", 29.9),
                new Produto(" 8ª Temporada Game of Thrones", 99.9),
                new Produto(" Poster", 10)
            };

            carrinho.AddRange(combo);                       // Esse método adiciona todos os itens da lista combo à lista carrinho com uma operação só
            Console.WriteLine(carrinho.Count);              // Dirá quantos elementos possui o carrinho
            carrinho.RemoveAt(3);                           // Remove o item de índice 3 do carrinho 

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);                            // Lista aceita repetição. Conseguimos adicionar um livro repetido à lista
            Console.WriteLine(carrinho.LastIndexOf(livro)); // O livro está tanto no índice 0 quanto no índice 3. Aqui vai mostrar o 3 que é o último
        }
    }
}
