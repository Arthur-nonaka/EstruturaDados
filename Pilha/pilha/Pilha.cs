

public class Pilha
{
    public Node top;

    public Pilha()
    {
        this.top = null;
    }

    public void Push(int value)
    {
        Node newNode = new Node(value);
        newNode.next = this.top;
        this.top = newNode;
    }

    public Node Pop()
    {
        Node current = this.top;
        if (!this.isNull())
        {
            this.top = this.top.next;
        }
        return current;
    }

    public bool Search(int value)
    {
        Node current = this.top;
        while (current != null)
        {
            if (current.value == value)
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public int Count()
    {
        int i = 0;
        Node current = this.top;
        while (current != null)
        {
            i++;
            current = current.next;
        }
        return i;
    }

    public int CountOddNumbers()
    {
        int i = 0;
        Node current = this.top;
        while (current != null)
        {
            if (current.value % 2 == 1)
            {
                i++;
            }
            current = current.next;
        }
        return i;
    }

    public void SplitInTwo(ref Pilha pilha2, ref Pilha pilha3) {
        Node current = this.top;
        while(current != null) {
            if(current.value >= 0) {
                pilha2.Push(current.value);
            }else {
                pilha3.Push(current.value);
            }
            current = current.next;
        }
        pilha2.Invert();
        pilha3.Invert();
    }

    public void Invert() {
        Fila fila = new Fila();
        Node current = this.top;
        while(current != null) {
            fila.insert(this.Pop().value);
            current = current.next;
        }
        current = fila.head;
        while(current != null) {
            this.Push(current.value);
            current = current.next;
        }
    }

    public bool isNull()
    {
        if (this.top == null)
        {
            return true;
        }
        return false;
    }

    public void Show()
    {
        Node current = this.top;
        while (current != null)
        {
            Console.WriteLine(current.value + "-> ");
            current = current.next;
        }
    }

}