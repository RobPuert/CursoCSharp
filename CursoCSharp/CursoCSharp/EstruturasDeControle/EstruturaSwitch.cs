using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch {
        public static void Executar() {
            Console.Write("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);                         // Vai pegar o que for digitado e tentar converter em int para atribuir à variável nota.

            switch (nota) {                                                    // diferente do If que trabalha com true or false, o switch trabalha com opções como um menu
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;                                      // os breaks são necessários senão ele dá erro. Não tenta executar tudo em cascata (fall through) como no JS
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");                                      // repare que tem 3 sentenças de código. As chaves são opcionais no switch
                    Console.WriteLine("Parabéns!");
                    break;
                default:                                                             // default é para o caso do número digitado ser maior que 5, por exemplo.
                    Console.WriteLine("nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
