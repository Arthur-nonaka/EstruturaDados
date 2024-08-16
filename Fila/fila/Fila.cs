public class Fila
{
    public Node head;
    public Node end;

    public Fila()
    {
        this.head = null;
        this.end = null;
    }

    public bool isNull()
    {
        if (this.head == null && this.end == null)
        {
            return true;
        }
        return false;
    }

    public void insert(int value)
    {
        Node newNode = new Node(value);

        if (this.isNull())
        {
            this.head = newNode;
            this.end = newNode;
        }
        else
        {
            this.end.next = newNode;
            this.end = newNode;
        }
    }

    public void remove()
    {
        if (!this.isNull())
        {
            this.head = this.head.next;
        }
    }

    public void removeNegative()
    {
        if (!this.isNull())
        {
            Node current = this.head;
            Node before = null;

            while (current != null)
            {
                if (current.value < 0)
                {
                    if (current == this.head)
                    {
                        this.head = this.head.next;
                    }
                    else
                    {
                        before.next = current.next;
                        current = before;
                    }
                }
                before = current;
                current = current.next;

            }
        }
    }

    public Fila Join(Fila fila2 ) {
        Fila fila3 = new Fila();
        Node current = this.head;
        while(current != null) {
            fila3.insert(current.value);
            current = current.next;
        }
        
        current = fila2.head;
        while(current != null) {
            fila3.insert(current.value);
            current = current.next;
        }


        return fila3;
    }
    public void show()
    {
        Node current = this.head;

        while (current != null)
        {
            Console.Write(current.value + "->");
            current = current.next;
        }
    }

    public int Count()
    {
        if (!this.isNull())
        {
            Node current = this.head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
        return 0;
    }
}