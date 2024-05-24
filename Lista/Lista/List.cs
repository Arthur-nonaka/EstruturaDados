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

    public void insertStart(int value)
    {
        Node newNode = new Node(value);
        if (this.head == null)
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

    public void remove(int value)
    {
        Node current = this.head;
        Node currentBefore;
        Node currentAfter;
        while (current != null)
        {
            if (current.value == value)
            {

            }
            current = current.next;
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

    public void insertMiddle(int value)
    {
        Node newNode = new Node(value);
        Node after = this.head.next;
        Node current = this.head;
        while (current != null)
        {
            if (current.value < newNode.value && after.value > newNode.value)
            {
                current.next = newNode;
                newNode.next = after;
            }
            else
            {
                after = after.next;
                current = current.next;
            }
        }
    }

    public void insertEnd(int value)
    {
        Node newNode = new Node(value);

        this.end.next = newNode;
        this.end = newNode;

        newNode.next = null;
    }
}