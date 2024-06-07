using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            lista.insertStart(1);
            lista.insertEnd(100);
            lista.insertMiddle(2);
            lista.insertMiddle(5);
            lista.insertMiddle(6);
            lista.insertMiddle(3);
            lista.remove(5);
            // lista.insertMiddle(11);
            // lista.insertMiddle(-1);
            lista.showList();

        }
    }
}