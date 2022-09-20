// See https://aka.ms/new-console-template for more information
public class Dvd : Document
{
    int serialNumber;

    //Constructor
    public Dvd(int serialNumber) : base("mioDVD", 2020, "Comedy", 166, "autore")
    {
        serialNumber = serialNumber;
    }

    public int duration(int duration)
    {
        return duration;
    }

}

