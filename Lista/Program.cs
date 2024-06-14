using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            // lista.insertStart(1);
            lista.insertSort(-2);
            lista.insertSort(5);
            lista.insertSort(6);
            // lista.insertEnd(10);
            // lista.insertEnd(11);
            lista.remove(6);
            // lista.insertEnd(1);
            // lista.insertEnd(2);
            lista.showList();

        }
    }
}