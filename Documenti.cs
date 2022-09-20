// See https://aka.ms/new-console-template for more information
public class Document
{
/*    protected string title;
    protected int year;
    protected string genre;
    protected bool isAvailable;
    protected int shelfNumber;
    protected string author;*/


    //Constructor

    public Document(string Title, int Year, string Genre, int ShelfNumber, string Author)
    {
        this.Title = Title;
        this.Year = Year;
        this.Genre = Genre;
        this.IsAvailable = IsAvailable;
        this.ShelfNumber = ShelfNumber;
        this.Author = Author;
    }


    //Properties

    public string Title { get; set; }
    
    public int Year { get; set; }
    
    public string Genre { get; set; }

    public bool IsAvailable { get; set; }

    public int ShelfNumber { get; set; }

    public string Author { get; set; }

}