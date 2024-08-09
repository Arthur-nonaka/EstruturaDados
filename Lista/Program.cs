using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            // ListMine lista = new ListMine();
            // // lista.insertStart(1);
            // lista.insertSort(-2);
            // lista.insertSort(5);
            // lista.insertSort(6);
            // // lista.insertEnd(10);
            // // lista.insertEnd(11);
            // lista.remove(6);
            // // lista.insertEnd(1);
            // // lista.insertEnd(2);
            // lista.showList();

            ListFuncionario lista = new ListFuncionario();
            // lista.insertSort(new Funcionario("Pedro", 18, "(18)997963229", 200));
            // lista.insertSort(new Funcionario("Arthur", 18, "(18)9953263229", 0));
            // lista.insertSort(new Funcionario("Paulo", 18, "(18)975563229", 1000));

            lista.showList();

        }
    }
}