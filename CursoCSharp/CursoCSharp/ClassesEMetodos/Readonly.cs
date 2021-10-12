using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;           // readonly é imutável. Pode ser inicializado no construtor. Const ñ dá pq ela requer inicialização na hora da declaração
                                               // Além disso, Não pode fazer uma const DateTime
        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}
