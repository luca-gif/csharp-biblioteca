// See https://aka.ms/new-console-template for more information
public class User
{
    string name;
    string surname;
    string email;
    string password;
    int phone;

    //Constructor
    public User(string cognome, string nome, string email, string password, int telefono)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }

    //Properties
    public string Name { get; set; }

    public string Surname { get; set; }

    public string getEmail { get; set; }

    public string getPassword { get; set; }

    public int getphone { get; set; }

}
