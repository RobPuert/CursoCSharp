using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");   // Variáveis do tipo int são struct e realizam atribuição por valor (se não estiverem dentro de uma class).
                                                            // Criam cópia do valor

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{ dep.Nome} { copiaDep.Nome}");
            Console.WriteLine($"{ dep.Idade} { copiaDep.Idade}");       // Dentro da class, mesmo os int fazem atribuição por referência de memória.

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{ dep.Nome} { copiaDep.Nome}");
            Console.WriteLine($"{ dep.Idade} { copiaDep.Idade}");
        }
    }
}
