using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;                                                    // atributo de instância (não é static)
        public static void Executar() {                              // método que pertence à Classe (static) e não consegue acessar o atributo de instância            
            DesafioAtributo desafio = new DesafioAtributo();        // Instanciando um novo objeto fica possível acessar o atributo estático
            Console.WriteLine(desafio.a);
        }
    }
}
