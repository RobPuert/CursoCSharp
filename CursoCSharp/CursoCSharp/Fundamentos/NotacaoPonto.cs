using System;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!")  // var com tipo implícito. Colocando o ponto depois da string olá ele mostra os métodos que podemos usar
                .Replace("World!", "Mundo!");           //Nesse caso o ToUpper vai transformar em OLÁ, o insert vai inserir o " World!" na posição 3 (ou seja depois do Á que é a posição 2)
            Console.WriteLine(saudacao);                // e o replace vai trocar world por mundo.

            Console.WriteLine("Teste".Length);          // Para lenght não precisa de parênteses porque vai retornar só o valor do tamanho da string (5 nesse caso)

            string valorImportante = null;                // Por ser uma variável com valor null (Vazia), daria erro ao tentar imprimir o lenght dela
            Console.WriteLine(valorImportante?.Length);   // Mas podemos usar a navegação segura (a interrogação depois do nome da variável). Assim se for um valor não nulo ele retorna o valor e se for null, ela retorna um espaço em branco apenas.
        }
    }
}
