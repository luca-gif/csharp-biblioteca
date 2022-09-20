// See https://aka.ms/new-console-template for more information
public class Documenti
{
    string title;
    int age;
    string genre;
    bool isAvailable;
    int shelfNumber;
    string author;


    //Constructor

    public Documenti(string title, int age, string genre, bool isAvailable, int shelfNumber, string author)
    {
        this.title = title;
        this.age = age;
        this.genre = genre;
        this.isAvailable = isAvailable;
        this.shelfNumber = shelfNumber;
        this.author = author;
    }


    //Properties

    public string Title { get; set; }
    
    public int Age { get; set; }
    
    public string Genre { get; set; }

    public bool IsAvailable { get; set; }

    public int ShelfNumber { get; set; }

    public string Author { get; set; }

}