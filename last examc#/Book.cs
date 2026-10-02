public class Book
{
    public string? Title;
    private string? author;
    public void Borrow(int days)
    {
        System.Console.WriteLine();
    }
    public DateTime Return(DateTime returndata)
    {
        return returndata.AddDays(1);
    }

}