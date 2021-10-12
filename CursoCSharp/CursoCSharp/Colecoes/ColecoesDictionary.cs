using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {                       // Aceita repetição no valor, mas não na chave. Se for ano : filme, só poderá ter 1 filme por ano
            var filmes = new Dictionary<int, string>();      // Usando generic. Dicionário = par chave/valor, precisa estabelecer os tipos. Nesse caso key int, string value

            filmes.Add(2000, "Gladiador");                      // adicionando elementos ao dicionário
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);        // filmes[2004]   pela chave retornará o valor. Dá erro se a chave não existir
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));  //Com esse método não dá erro se a chave não existir. Retorna uma string vazia como padrão
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));  //uma forma de procurar um item pelo valor. Retorna true ou false. Nesse caso false pq não tem esse filme

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // remove um item se a chave existir e retorna true. Senão retorna false

            filmes.TryGetValue(2006, out string filme2006);                     // Atribuirá à variável filme2006 o elemento q tentou pegar com esse método. 
            Console.WriteLine($"Filme {filme2006}!");                          // Se a key não existir não dá erro. Retorna string vazia

            foreach (var chave in filmes.Keys) {                                // percorrerá as chaves e na linha de baixo imprimirá só as chaves tbm
                Console.WriteLine(chave);                   
            }
            foreach (var valor in filmes.Values) {                              // percorrerá os valores e na linha de baixo imprimirá só os valores tbm
                Console.WriteLine(valor);
            }
            foreach (KeyValuePair<int, string> filme in filmes) {               // percorre o par e precisa passar os tipos
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
            foreach (var filme in filmes) {                                    // Forma mais simples de fazer a mesma coisa de cima. Deixando o compilador inferir os tipos
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
