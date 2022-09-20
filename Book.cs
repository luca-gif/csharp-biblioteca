// See https://aka.ms/new-console-template for more information
public class Book : Document
{
    string ISBN;

    //Constructor
    public Book(string iSBN) : base("titolo", 2015, "History", 15, "autore")
    {
        ISBN = iSBN;
    }

    public int totalPages(int pages)
    {
        return pages;
    }

}

