using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento;                      // não precisa inicializar a variável bomComportamento como false porque false já é o padrão de início, mas ela ainda precisa ser inicializada antes de alguma validação
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")           
            //    bomComportamento = true;                // Como é uma única sentença de código, não precisa de chaves no if. Não precisa de else porque comComportamento já inicia false

            //bomComportamento = entrada == "S" || entrada == "s";    //bomComportamento receberá true se entrada for s ou S. Senão permanece false como definido anteriormente
            bomComportamento = entrada.ToLower() == "s";        // passa o S para minúsculo se for digitado maiúsculo. Compara c/ minúsculo para atribuir true. Se for diferente, fica o false definido anteriormente

            if (nota >= 9.0 && bomComportamento) {              // não tem ; nessa linha porque se não isolaria o próximo bloco de código e ele precisa fazer parte do if.
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
