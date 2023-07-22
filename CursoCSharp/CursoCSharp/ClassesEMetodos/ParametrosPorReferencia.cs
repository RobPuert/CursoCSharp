using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;                                             // O out obriga a inicializar a variável na declaração do método antes dela ser recebida mais adiante
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar() {
            int a = 3;                      // O ref obriga a inicializar a variável na hora de usar para passá-la a outro método
            AlterarRef(ref a);              // passando ref (Referência de memória), a função vai alterar a para 3 lá em cima e somar 1000 antes de imprimir                                     uma cópia de a e imprimiria 3. 
            Console.WriteLine(a);

            // int b;
            AlterarOut(out int b, out int c);          // por segurança antibug, prefira o out porque ele só gera uma saída quando o método termina.
            Console.WriteLine($"{b} {c}");
        }
    }
}
