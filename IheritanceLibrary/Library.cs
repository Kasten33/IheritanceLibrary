using System;
namespace InheritanceLibrary;

public class Program
{
    static void Main()
    {

        Book book = new ();
        DVD dVD = new ();
        Magazine magazine = new ();
        book.inquery();
        dVD.inquery2 ();    
        magazine.inquer3 ();
    }
}



public class LibraryItem
{
    private string Title = "Stirng";
    private string Author = "St";

    public void Callback()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Author);
    }
}
class Book : LibraryItem
{
    private string PageCount = "100";
    public void inquery()
    {
        Callback();
        Console.WriteLine(PageCount);
    }
}
class DVD : LibraryItem
{
    private string Duration = "1000";

    public void inquery2()
    {
        Callback();
        Console.WriteLine(Duration);
    }
}
class Magazine : LibraryItem
{
    private int IssueNumber = 1;

    public void inquer3()
    {
        Callback();
        Console.WriteLine(IssueNumber);
    }
}


