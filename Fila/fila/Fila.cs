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

    public void insert(int value) {
        Node newNode = new Node(value);

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
            Console.Write(current.value + "->");
            current = current.next;
        }
    }
}