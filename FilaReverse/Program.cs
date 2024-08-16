using System;

namespace filas{
    class Program {
        static void Main(string[] args) {
            Fila fila = new Fila();
            fila.insert(10);
            fila.insert(20);
            fila.insert(30);
            fila.remove();
            fila.show();

        }
    }
}