namespace Clients;

public class Client {
    public string name {get; set;}
    public int age {get; set;}
    public int valuePaid {get; set;}
    public bool isHalf {get; set;}

    public Client(string name, int age, int valuePaid, bool isHalf ) {
        this.name = name;
        this.age = age;
        this.valuePaid = valuePaid;
        this.isHalf = isHalf;
    }

}