using System;

namespace filas{
    class Program {
        static void Main(string[] args) {
            Fila fila = new Fila();

            fila.insert(10);
            fila.insert(-20);
            fila.insert(-30);
            fila.insert(-50);
            fila.insert(20);

            Fila fila2 = new Fila();
            fila2.insert(1436430);
            fila2.insert(-643646);
            fila2.insert(54350);

            Fila fila3 = fila.Join(fila2);
            fila3.show();

        }
    }
}