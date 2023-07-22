using System;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum {                    // Não podem haver dois métodos com a mesma assinatura (nome E parâmetros) dentro de uma mesma classe.
        public int Somar(int a, int b) {        // public para deixar visível fora da Classe. int antes de Somar para "prometer" um int como retorno
            return a + b;                       // como "prometeu" um retorno (está int e não void), tem que ter return.  a e b são parâmetros de entrada.
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Dividir(int a, int b) {
            return a / b;
        }
    }
    class CalculadoraCadeia {
        int memoria;                                // Usamos letra minúscula porque não é uma variável publica.

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;                                // Retorna a própria instância da Classe Calculadora. Permitirá chamar vários métodos encadeados na mesma sentença
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado() {
            return memoria;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();          // Usando construtor padrão porque não foi definido nenhum
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(10, 5));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();   // Encadeia várias chamadas de métodos que retornam a própria Classe

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();          // Aqui terminou com um int como return. Então não dá para encadear + chamadas
            Console.WriteLine(resultado);
        }
    }
}
