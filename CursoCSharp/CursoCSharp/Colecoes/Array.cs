using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {              // Array é estático. Uma vez criado, SEMPRE terá a mesma quantidade de elementos. Dá pra criar outro e passar os dados.
            string[] alunos = new string[5];        // Criou um array chamado alunos que guardará 5 elementos do tipo string. Não pode misturar tipos como em Python.
            alunos[0] = "Anderson";                // Array é indexado tal qual a lista em Python. Tentar colocar um elemendo em um índice out of range dará erro.
            alunos[1] = "Bia";                    // Uma forma de atribuir elementos ao array é assim: pelo índice
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);           //  imprimindo cada aluno do array com foreach
            }

            double somatorio = 0;                            // Criou uma variável do tipo double com valor 0
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };   // Não especificou quantos elementos, dá pra colocar qtos quiser. Depois de inicializada não dá pra dar append.

            foreach (var nota in notas) {
                somatorio += nota;                  // acumulando os valores das notas na variável somatório com foreach
            }

            //for (int i = 0; i < notas.Length; i++) {      // acumulando os valores das notas na variável somatório com for
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };        // Tipo char usado para letras
            string palavra = new string(letras);                // Dá pra definir uma string usando os elementos do array assim sem foreach
            Console.WriteLine(palavra);
        }
    }
}
