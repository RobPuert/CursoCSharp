using System;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";  // A variável resultado recebe o resultado de uma expressão. (nota >= 7.0). Caso retorne true,
                                                                        // a primeira opção depois da interrogação será atribuída à variável ("Aprovado"). Caso retorne                                         false,
                                                                        // a opção depois dos dois pontos ("Reprovado") será atribuída à variável.
            Console.WriteLine(resultado);

            var nota2 = 7.0;
            bool bomComportamento = false;
            string resultado2 = nota2 >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado2);
        }
    }
}
