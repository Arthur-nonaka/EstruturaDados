using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            lista.insertStart(1);
            lista.insertSort(-2);
            lista.insertSort(5);
            lista.insertSort(6);
            lista.insertSort(100);
            lista.insertSort(-10);
            lista.insertSort(100);
            lista.insertSort(5);
            lista.showList();

        }
    }
}