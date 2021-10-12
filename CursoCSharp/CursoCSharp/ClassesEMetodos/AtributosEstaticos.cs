using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;                                // static = Desconto NA Classe então valerá para todos os produtos.
        public Produto(string nome, double preco, double desconto) {        // Construtor definido explicitamente
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto() {                                                  // Construtor padrão definido explicitamente

        }
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);                  // Obj instanciado usando o construtor explícito

            var produto2 = new Produto() {                                   // Obj instanciado usando o construtor padrão
                Nome = "Borracha",
                Preco = 5.3,                
            };

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.5;                                             // static = Desconto NA Classe então valerá para todos os produtos.            
        }
    }
}
