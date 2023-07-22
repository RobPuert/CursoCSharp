using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro {
        public string Modelo;                       // Atributos da Classe precisam ter a 1ª letra maiúscula
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {       // Definindo um construtor que exige argumentos. Parâmetros com 1ª letra minúscula
            Modelo = modelo;                                           // Atribuindo os parâmetros do construtor aos Atributos da classe
            Fabricante = fabricante;                                   // Poderíamos usar também this.Modelo = Modelo  (this é o do atributo) caso de nomes idênticos
            Ano = ano;
        }

        public Carro() {                                    // Esse é o construtor padrão, vem quando não definimos um ou também podemos definí-lo explícitamente

        }
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();                           // Construtor padrão que toda classe tem. Não recebe parâmetros e tem o mesmo nome da Classe
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);                                 // Construtor definido que recebe parâmetros e tem o mesmo nome da Classe
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",                                // Terceira forma de instanciar um objeto
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
