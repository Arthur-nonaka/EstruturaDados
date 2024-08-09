public class Node {
    public int value;
    public Funcionario funcionario;
    public Node next;

    public Node(Funcionario funcionario = null, int value = 0 ) {
        this.funcionario = funcionario;
        this.value = value;
        this.next = null;
    }


}