using System;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto {
        void MoverNaDiagonal(int delta);            // Métodos de interface não podem ser privados. Por padrão são sempre públicos.
    }

    struct Coordenada: Ponto {                      // Definindo atributos da Struct. O Struct está atrelado à interface Ponto
        public int X;
        public int Y;

        public Coordenada(int x, int y) {           // Definindo construtor da Struct
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) {     // Definindo métodos da Struct
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;           // Uma diferença entre struct e class está que o class não permitiria iniciar assim.  Só com new
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
