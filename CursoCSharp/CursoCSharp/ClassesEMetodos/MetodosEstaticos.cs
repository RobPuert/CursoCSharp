using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        public static int Multiplicar(int a, int b) {       // static significa que esse método não pertence mais ao Objeto e sim a Classe
            return a * b;
        }
        public int Somar(int a, int b) {         // public = método visível para qualquer outro código acessar, retorno tipo (int), nome (Somar), parâmetros
            return a + b;
        }
    }
    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);      // Devido ao static, devo chamar o método s/ instanciar a Classe em um novo obj antes
            Console.WriteLine("Resultado {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();       // o Método Somar não tem static, então precisa de uma nova instância antes de acessar
            Console.WriteLine(calc.Somar(2,2));
        }
    }
}
