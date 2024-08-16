using System;

namespace Clients{
    class Program {
        static void Main(string[] args) {
            Fila fila = new Fila();
            fila.insert(new Client("Arthur", 18, 43, false));
            fila.insert(new Client("Paulo", 18, 20, true));
            fila.insert(new Client("Matheus", 18, 43, false));
            fila.insert(new Client("Pedro", 18, 20, true));
            fila.remove();
            fila.remove();
            fila.show();

            if(fila.Search("Arthur") == true) {
                Console.WriteLine("Achou");
            }
            if(fila.Search("Pedro") == true) {
                Console.WriteLine("Achou");
            }

        }
    }
}