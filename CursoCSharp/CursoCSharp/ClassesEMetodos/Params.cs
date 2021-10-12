using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) {  // Recebe 1 conj d params variáveis. Posso passar qtos params quiser e fica armazenado no array pessoas.
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
            public static void Executar() {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");
        }
    }
}
