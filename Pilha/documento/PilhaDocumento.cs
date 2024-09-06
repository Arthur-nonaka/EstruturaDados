public class PilhaDocumento {
    public Documento top;

    public PilhaDocumento() {
        this.top = null;
    }

    public void Push(string name, string extension, int size) {
        Documento novoDocumento = new Documento(name,extension, size);
        novoDocumento.next = this.top;
        this.top = novoDocumento;
    }

    public bool isNull() {
        if(this.top == null) {
            return true;
        }
        return false;
    }

    public Documento Pop() {
        Documento current = this.top;
        if(!this.isNull()) {
            this.top = this.top.next;
        }
        return current;
    }

    public bool Search(string name) {
        Documento current = this.top;
        while(current != null) {
            if(current.name == name) {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void Show() {
        Documento current = this.top;
        while(current != null) {
            current.Show();
            Console.WriteLine("--");
            current = current.next;
        }
    }

}