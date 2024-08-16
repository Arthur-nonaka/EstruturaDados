namespace Clients;

public class Fila {
    public Node head;
    public Node end;

    public Fila() {
        this.head = null;
        this.end = null;
    }

    public bool isNull() {
        if(this.head == null && this.end == null) {
            return true;
        }
        return false;
    }

    public void insert(Client client) {
        Node newNode = new Node(client);

        if(this.isNull()) {
            this.head = newNode;
            this.end = newNode;
        }else {
            this.end.next = newNode;
            this.end = newNode;
        }
    }
    
    public void remove() {
        if(!this.isNull()) {
            this.head = this.head.next;
        }
    }
    public void show() {
        Node current = this.head;

        while(current != null) {
            Console.WriteLine(current.client.name );
            Console.WriteLine(current.client.age);
            Console.WriteLine(current.client.valuePaid);
            Console.WriteLine(current.client.isHalf);
            Console.WriteLine("->");
            current = current.next;
        }
    }

    public bool Search(string name) {
        Node current = this.head;
        while(current != null) {
            if( current.client.name == name)
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }
}