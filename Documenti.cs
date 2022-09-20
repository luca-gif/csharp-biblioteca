// See https://aka.ms/new-console-template for more information
public class Document
{
    protected string title;
    protected int year;
    protected string genre;
    protected bool isAvailable;
    protected int shelfNumber;
    protected string author;


    //Constructor

    public Document(string title, int year, string genre, int shelfNumber, string author)
    {
        this.title = title;
        this.year = year;
        this.genre = genre;
        this.isAvailable = isAvailable;
        this.shelfNumber = shelfNumber;
        this.author = author;
    }


    //Properties

    public string Title { get; set; }
    
    public int Year { get; set; }
    
    public string Genre { get; set; }

    public bool IsAvailable { get; set; }

    public int ShelfNumber { get; set; }

    public string Author { get; set; }

}