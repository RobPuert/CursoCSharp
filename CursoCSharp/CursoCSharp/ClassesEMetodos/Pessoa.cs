using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa {
        public string Nome;        // Use a 1ª letra maiúscula para nomes de atributos e métodos diretos da Classe. Para outros atributos comece com minúscula
        public int Idade;          // Public serve p/ esse atributo ficar visível fora da classe (em outros namespaces, no caso)

        public string Apresentar() {                    // Criamos um método para essa Classe. Não precisou de parâmetros porque usará os próprios atributos.
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");    // o Tipo do retorno precisa ser especificado.
        }
        public void ApresentarNoConsole() {             // void é usado quando o método não retorna nada. tipo um None em Python.
            Console.WriteLine(Apresentar());            // É possível chamar um método da classe dentro do outro.
        }
        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}

// C# é baseado em classes. As classes são os tipos. int e string por exemplo são classes (int na verdade é uma Struct, mas é semelhante à uma classe)
// Então quando você cria uma classe, está criando um tipo personalizado.
// Por isso que instanciamos a classe de forma parecida à declaração de uma variável.
// variável: string nome = "Robson"
// classe: Pessoa sicrano = new Pessoa();