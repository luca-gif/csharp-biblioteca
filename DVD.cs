// See https://aka.ms/new-console-template for more information
public class Dvd : Document
{

    //Constructor
    public Dvd(int durate) : base(5151,"Harry Potter", 2020, "Comedy", 166, "autore")
    {
        Duration = durate;
    }

    public int Duration { get; set; }

}

