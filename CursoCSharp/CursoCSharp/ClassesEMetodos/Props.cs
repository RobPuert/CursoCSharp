using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {
        double desconto = 0.1;                          // sem public nem private, é private. Iniciamos com letra minúscula por convenção

        string nome;                                    // atributo pivado nome que é acessado através da propriedade Nome abaixo
        public string Nome {                            // Qdo tenta ler esse Nome, ele chama o get abaixo e quando tenta alterar o valor ele automaticamente chama o set
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            //get {
            //     return Preco - (desconto * Preco);
            get => Preco - (desconto * Preco);          // Lambda   -  há um return implícito.
        }
        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            // op1.PrecoComDesconto = 3000;  -  Impossível porque é somente leitura, não tem método set, somente get

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Hidráulica";            // Parece atributo público mas tem um get e set interno definido lá em cima
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);                // o get interno permite formatar. Por exemplo, colocando texto adicional
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);

            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
