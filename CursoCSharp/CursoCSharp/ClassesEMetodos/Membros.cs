﻿using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();          // Instanciando a Classe Pessoa em um novo objeto
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();          //U método para apresentar direto no Console não é tão flexível nem muito usado
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();              // É possível usar inferência. NEsse caso o C# infere que a variável fulano é do tipo Pessoa
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();     // retornar uma string é melhor porque dá pra fqazer o que quiser com ela depois
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
