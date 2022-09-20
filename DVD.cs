// See https://aka.ms/new-console-template for more information
public class DVD : Document
{
    string serialNumber;

    public DVD(int serialNumber) : base("titolo", 2015, "History", 15, "autore")
    {
        serialNumber = serialNumber;
    }


}

