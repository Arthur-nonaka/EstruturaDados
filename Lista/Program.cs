using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            lista.insertStart(1);
            lista.insertStart(10);
            lista.insertMiddle(5);
            lista.showList();

        }
    }
}