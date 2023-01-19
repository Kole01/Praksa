public class Writer:Person
{
    public int NumberOfBooks;

    
    public Writer(string FirstName, string LastName, int NumberOfBooks){
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.NumberOfBooks=NumberOfBooks;
    }

    public override void  work(){
        Console.WriteLine("Krecem pisati!");
        NumberOfBooks ++;
    }
}