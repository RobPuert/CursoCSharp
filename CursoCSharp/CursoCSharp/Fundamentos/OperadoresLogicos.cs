using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;           //Inferiu que é do tipo bool
            var executouTrabalho2 = true;           //Inferiu que é do tipo bool

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;      //como está trabalhando com dois bool, comprouTv50 pode receber bool    && (and)
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;    // || (or)
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;        //  ^  (ou exclusivo) dá falso se forem dois lados falsos ou dois lados verdadeiros.
            Console.WriteLine($"Comprou a Tv 32? {comprouTv32}");

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);       //  !  (negação / inverte valor true or false) - é falso que comprou sorvete?
        }
    }
}
