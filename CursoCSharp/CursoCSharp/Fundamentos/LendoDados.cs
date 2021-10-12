using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();               //Console.Readline = input

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());      //por padrão o ReadLine só recebe string. Então precisamos do in.Parse para transformar em int e armazenar na variável int que definimos.

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),  //ao digitar um double, use o separador de cents de acordo com o idioma do SO da máquina. Aqui é Windows em PTBR então usamos vírgula.
                CultureInfo.InvariantCulture);                // Usando o system.globalization e essa linha, ignoramos o padrão de idioma e usamos o ponto para separar centavos. (Ainda imprime vírgula)

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
