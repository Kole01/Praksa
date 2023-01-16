public abstract class Person : IPerson
{
    private String firstName;
    public String FirstName
    {
    get { return firstName; }
    set { firstName = value; }
    }

    private String lastName;
    public String LastName
    {
    get { return lastName; }
    set { lastName = value; }
    }

    public Person(){}

    public Person (String FirstName, String LastName){
        this.FirstName=FirstName;
        this.LastName=LastName;
    }

    public void sayHello(){
        Console.WriteLine("Hello");
    }

    public virtual void work(){}

}