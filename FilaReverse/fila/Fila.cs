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
            newNode.next = this.head;
            this.head = newNode;
        }
    }
    
    public void remove() {
        if(!this.isNull()) {
            Node current = this.head;
            Node before = null;
            while(current != this.end) {
                before = current;
                current = current.next;
            }
            before.next = null;
            this.end = before;

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