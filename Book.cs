// See https://aka.ms/new-console-template for more information
public class Book : Document
{

    //Constructor
    public Book(int pages) : base(51545, "New York", 2015, "genere", 15, "autore")
    {
        this.TotalPages = pages;
     }

    public int TotalPages { get; set; }
}

