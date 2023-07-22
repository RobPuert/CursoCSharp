using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao {
        public static int Somar(int a = 1, int b = 1) {     // a e b receberão o valor 1 como padrão caso o valor não seja informado (ref e out não podem ter padrão)
            return a + b;
        }
        public static void Executar() {
            Console.WriteLine(Somar(10, 23));       // pssando 2 parâmetros normalmente
            Console.WriteLine(Somar(50));           // passando só 1 ele assume como o primeiro (a) e define o b como o padrão que colocamos (1)
            Console.WriteLine(Somar());             // passando nenhum parâmetro ele pega os dois padrões (a,1 e b, 1)
            Console.WriteLine(Somar(b: 7));         // passando nomeado b: 7, ele pega o padrão de a (1)
        }
    }
}
