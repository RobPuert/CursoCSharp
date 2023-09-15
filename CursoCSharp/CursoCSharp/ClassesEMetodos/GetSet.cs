using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto {                             // Public deixa essa classe acessível p/ qualquer cód. fora do namespace.
        private string Marca;                       // Private deixa os atributos encapsulados dentro da classe.
        private string Modelo;                      // Escrever private não é obrigatório. Se não escrever public, é automaticamente private
        private uint Cilindrada;                    // Colocamos uint aqui para não permitir números negativos

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);                        // Passando os atributos com Set no construtor obriga a passar pelas regras do método Set da Classe
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() {

        }
        public string GetMarca() {                      // O tipo do get precisa ser igual ao retorno como em qualquer método. Ele precisa ser público
            return Marca;
        }
        public void SetMarca(string marca) {            // Por padrão o método set não retorna nada (void). Ele tbm precisa ser public
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            //if(cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            //Cilindrada = Math.Abs(cilindrada);              // Math.Abs transforma negativo em positivo e se for positivo não faz nada

            Cilindrada = cilindrada;
        }
    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());;
        }
    }
}
