namespace Clients;

public class Node {
    public Client client;
    public Node next;

    public Node(Client client) {
        this.client = client;
        this.next = null;
    }
}