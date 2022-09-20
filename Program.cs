// Creo user

List <User> users = new List<User>();

users.Add(new User("Luca", "Rossi", "luca@rossi.com", "psw", 370554515));
users.Add(new User("Marco", "Versi", "marco@verdi.com", "psw", 370544415));

foreach (var user in users)
{
    Console.WriteLine(user.Name);
}

// Creo libri

List <Book> books = new List<Book>();

books.Add(new Book(114));
books.Add(new Book(134));
books.Add(new Book(229));

// Creo Dvd

List<Dvd> dvd = new List<Dvd>();

dvd.Add(new Dvd(164));
dvd.Add(new Dvd(184));
dvd.Add(new Dvd(203));


// Ricerca per titolo

Console.WriteLine("Cerchi un libro o un DVD?");
string search = Console.ReadLine();

if(search == "libro")
{
    Console.WriteLine("Inserisci un titolo");

    foreach(Book book in books)
    {
        if(book.Title == Console.ReadLine()){
            Console.WriteLine(book.Title);
                    }
        else
        {
            Console.WriteLine("Mi dispiace ma questo libro non è presente, scegline un altro!");
        }
    }
}

else if(search == "DVD")
{
    Console.WriteLine("Inserisci un titolo");

    foreach (Dvd dvdItem in dvd)
    {
        if (dvdItem.Title == Console.ReadLine())
        {
            Console.WriteLine(dvdItem.Title);
        }
        else
        {
            Console.WriteLine("Mi dispiace ma questo DVD non è presente, scegline un altro!");
        }
    }
}