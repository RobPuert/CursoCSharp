using System;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo {
        int a = 10;                                                    // atributo de instância (não é static). Não é um atributo da classe
        public static void Executar() {                              // método que pertence à Classe (static) e não consegue acessar o atributo de instância            
            DesafioAtributo desafio = new DesafioAtributo();        // Instanciando um novo objeto fica possível acessar o atributo não estático (da classe)
            Console.WriteLine(desafio.a);
        }
    }
}
