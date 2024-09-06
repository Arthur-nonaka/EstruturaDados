

public class Documento{
    public string name;
    public string extension;
    public int size;
    public Documento next;

    public Documento(string name, string extension, int size) {
        this.name = name;
        this.extension = extension;
        this.size = size;
        this.next = null;
    }

    public void Show() {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Extension: " + this.extension);
        Console.WriteLine("Size: " + this.size + "Kb");
    }
}