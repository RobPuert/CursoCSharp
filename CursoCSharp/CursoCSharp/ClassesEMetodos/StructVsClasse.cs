using System;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };             // ponto do tipo struct.  Em struct sempre há atribuição por valor
            SPonto copiaPonto1 = ponto1;                            //Atribuição por valor. Uma cópia do valor foi para a var cópia e mexer em um não altera o outro
            ponto1.X = 3;
            
            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };             //  ponto do tipo class.  Em class sempre há atribuição por referência
            CPonto copiaPonto2 = ponto2;                    // Atribuição por referência. Uma cópia do endereço de memória foi para a var cópia e mexer em um altera o outro
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
