using System;

namespace Atividade{
    class Program {
        static void Main(string[] args) {
            // PilhaDocumento pilha = new PilhaDocumento();

            // pilha.Push("Batata", "txt", 165);
            // pilha.Push("index", "js", 4020);
            // pilha.Push("batata", "png", 42020);
            // Console.WriteLine(pilha.Search("batata"));
            // pilha.Pop();
            // pilha.Pop();

            // pilha.Show();
            Pilha pilha2 = new Pilha();
            Pilha pilha3 = new Pilha();

            Pilha pilha = new Pilha();
            pilha.Push(51);
            pilha.Push(532);
            pilha.Push(12);
            pilha.Push(-10);
            pilha.Push(-13);
            pilha.Push(0);
            pilha.Push(-1);
            // Console.WriteLine(pilha.Count());
            // Console.WriteLine(pilha.CountOddNumbers());

            pilha.SplitInTwo(ref pilha2, ref pilha3);
            pilha.Show();
            Console.WriteLine("");
            pilha2.Show();
            Console.WriteLine("");
            pilha3.Show();

        }
    }
}