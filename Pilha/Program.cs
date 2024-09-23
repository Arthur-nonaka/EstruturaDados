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

            // Questao 2 Contar numero de elementos
            // Console.WriteLine(pilha.Count());

            // Questao 3 Contar numero impares
            // Console.WriteLine(pilha.CountOddNumbers());

            //Questao 4 Dividir

            // pilha.SplitInTwo(ref pilha2, ref pilha3);
            // pilha.Show();
            // Console.WriteLine("");
            // pilha2.Show();
            // Console.WriteLine("");
            // pilha3.Show();

            //Questao 5 Inverter

            // pilha.Push(1);
            // pilha.Push(4);
            // pilha.Push(3);

            // pilha.Invert();
            // pilha.Show();

            //Questao 6 Palindromo - estou usando int no lugar de string, mas a logica é a mesma
            // pilha.Push(1);
            // pilha.Push(2);
            // pilha.Push(3);
            // pilha.Push(3);
            // pilha.Push(1);

            // Console.WriteLine(pilha.isPalindromo());

            //Questao 7 Transferir Elementos
            
            pilha.Transfer(ref pilha2);
            pilha.Show();
            pilha2.Show();


        }
    }
}