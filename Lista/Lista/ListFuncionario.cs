public class ListFuncionario
{
    Node head;
    Node end;

    public ListFuncionario()
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
            Console.Write("->" + current.funcionario);
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

    public void insertStart(Funcionario funcionario)
    {
        Node newNode = new Node(funcionario);
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

    public void insertEnd(Funcionario funcionario)
    {
        Node newNode = new Node(funcionario);

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

    public void removerFim() {
        if(!this.isNull()) {
            Node before = null;
            Node current = null;

            if(this.Search(this.end.funcionario, ref current, ref before)) {
                current = null;
                before.next = null;
                this.end = before;
            }
        }
    }
    public void remove(Funcionario funcionario)
    {
        Node before = null;
        Node current = null;

        if (this.Search(funcionario, ref current, ref before))
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

    // public void insertPosition(Funcionario funcionario,Funcionario pos) {
    //     Node newNode = new Node(funcionario);

    //     Node current = this.head;
    //     Node currentBefore;
    //     for(Funcionario i = 0; i < pos; i++) {
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

    public void insertSort(Funcionario funcionario)
    {
        Node newNode = new Node(funcionario);
        Node current = this.head;
        Node before = null;
        if (this.isNull())
        {
            this.head = newNode;
            this.end = newNode;
            return;
        }
        if (string.Compare(newNode.funcionario.nome, current.funcionario.nome) <= 0)
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
            if (string.Compare(newNode.funcionario.nome, before.funcionario.nome) >= 0  && string.Compare(newNode.funcionario.nome, current.funcionario.nome) <= 0)
            {
                before.next = newNode;
                newNode.next = current;
                break;
            }
        }
    }


    public Boolean Search(Funcionario funcionario, ref Node current, ref Node before)
    {
        current = this.head;
        before = null;

        while (current != null)
        {
            if (current.funcionario == funcionario)
            {
                return (true);
            }
            before = current;
            current = current.next;
        }
        return false;

    }
}