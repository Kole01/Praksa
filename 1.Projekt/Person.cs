public abstract class Person : IPerson
{
    private string firstName;
    public string FirstName
    {
    get { return firstName; }
    set { firstName = value; }
    }

    private string lastName;
    public string LastName
    {
    get { return lastName; }
    set { lastName = value; }
    }

    public Person(){}

    public Person (string FirstName, string LastName){
        this.FirstName=FirstName;
        this.LastName=LastName;
    }

    public void sayHello(){
        Console.WriteLine("Hello");
    }

    public virtual void work(){}

}