public class Writer:Person
{
    public int NumberOfBooks;

    
    public Writer(String FirstName, String LastName, int NumberOfBooks){
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.NumberOfBooks=NumberOfBooks;
    }

    public override void  work(){
        Console.WriteLine("Krecem pisati!");
        NumberOfBooks ++;
    }
}