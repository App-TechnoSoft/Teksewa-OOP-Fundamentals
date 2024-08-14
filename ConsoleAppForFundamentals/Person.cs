namespace ABC;
class Person
{
    public Person()
    {        
    }

    public Person(string n, DateTime d, long i)
    {
        this.name = n;
        this.dob = d;
        this.nid = i;
    }

    public string name;
    public long nid;
    public DateTime dob;

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {this.name}\nNational Identifier: {this.nid}\nDate of Birth: {this.dob.ToString("ddd MMM dd, yyyy")}");
    }

    public static string PrintDetails(Person person) =>
        $"Name: {person.name}\nNational Identifier: {person.nid}\nDate of Birth: {person.dob.ToString("ddd MMM dd, yyyy")}";
}
