public class ListMine
{
    Node head;
    Node end;

    public ListMine()
    {
        this.head = null;
        this.end = null;
    }

    public void showList()
    {
        Node current = this.head;
        Console.WriteLine("Elementos: ");
        while (current != null)
        {
            Console.Write("->" + current.value);
            current = current.next;
        }
    }

    public Boolean isNull()
    {
        if (this.head == null && this.end == null)
        {
            return (true);
        }
        return (false);
    }

    public void insertStart(int value)
    {
        Node newNode = new Node(value);
        if (this.isNull())
        {
            this.end = newNode;
            this.head = newNode;
        }
        else
        {
            newNode.next = this.head;
            this.head = newNode;
        }

    }

    public void insertEnd(int value)
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

            newNode.next = null;
        }

    }
    public void remove(int value)
    {
        Node before = null;
        Node current = null;

        if (this.Search(value, ref current, ref before))
        {
            if (before != null)
            {
                before.next = current.next;
            }
            else {
                this.head = this.head.next;
            }
            current = null;
        }
    }

    // public void insertPosition(int value,int pos) {
    //     Node newNode = new Node(value);

    //     Node current = this.head;
    //     Node currentBefore;
    //     for(int i = 0; i < pos; i++) {
    //         if(current == null) {
    //             Console.WriteLine("Informe uma posicao valida");
    //             break;
    //         }
    //         if(i == pos - 1) {
    //             currentBefore = current;
    //         }

    //         current = current.next;
    //     }
    //     newNode.next = current.next;

    // }

    public void insertSort(int value)
    {
        Node newNode = new Node(value);
        Node current = this.head;
        Node before = null;
        if (this.isNull())
        {
            this.head = newNode;
            this.end = newNode;
            return;
        }
        if (newNode.value < current.value)
        {
            newNode.next = this.head;
            this.head = newNode;
            return;
        }
        while (current != null)
        {
            before = current;
            current = current.next;
            if (current == null)
            {
                before.next = newNode;
                this.end = newNode;
                break;
            }
            if (before.value <= newNode.value && current.value >= newNode.value)
            {
                before.next = newNode;
                newNode.next = current;
                break;
            }
        }
    }


    public Boolean Search(int value, ref Node current, ref Node before)
    {
        current = this.head;
        before = null;

        while (current != null)
        {
            if (current.value == value)
            {
                return (true);
            }
            before = current;
            current = current.next;
        }
        return false;

    }
}