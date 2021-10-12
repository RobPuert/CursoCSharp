using System;
using System.Collections;           // ArrayList só está disponível em system.Collections.   Não pode ser o Generic.  Serve para misturar tipos na lista.

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());      // items de vários tipos na Array List
            }
        }
    }
}
