using System;

namespace CursoCSharp.Fundamentos
{
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;      //conversão de inteiro para double implícita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //int notaTruncada = nota;            Não é possível converter implicitamente double em int porque perderia informação (o .7 no caso)
            double notaTruncada = (int) nota;   // Casting = conversão explícita para mostrar ao compilador que você está ciente de que perderá informação.
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);      //Essa conversão só funciona se o usuário digitar mesmo um número inteiro. Senão, dá erro
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);       //o tipo inteiro tem 4 bytes ou seja 32 bits, por isso o nome (toInt32)
            Console.WriteLine($"Resultado: {idadeInteiro}");   //Essa conversão só funciona se o usuário digitar mesmo um número inteiro. Senão, dá erro

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);                 //Aqui ele tenta converter para inteiro. Se não for possível (ex.: digitaram um texto), retorna 0
            Console.WriteLine($"Resultado 1: {numero1}");       

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);        // Nesse caso, a variável numero do tipo int foi criada dentro do TryParse e O input tbm dispensou                                                            a variável palavra
            Console.WriteLine($"Resultado 2: {numero2}");               //Aqui ele tenta converter para inteiro. Se não for possível (ex.: digitaram um texto), retorna 0
        }
    }
}
