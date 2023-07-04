using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {                        // pode colocar var ou o mesmo tipo presente na variável que está percorrendo
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };   // pode colocar var ou o mesmo tipo presente na variável que está percorrendo
            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
