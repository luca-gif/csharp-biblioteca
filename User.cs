// See https://aka.ms/new-console-template for more information
public class User
{
    string name;
    string surname;
    string email;
    string password;
    int phone;

    public User(string cognome, string nome, string email, string password, int telefono)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }

    //GET
    public string getName()
    {
        return this.name;
    }

    public string getSurname()
    {
        return this.surname;
    }

    public string getEmail()
    {
        return this.email;
    }

    public string getPassword()
    {
        return this.password;
    }

    public int getphone()
    {
        return this.phone;
    }


    //SET

    public void setName(string name)
    {
        this.name = name;
    }

    public void setSurname(string surname)
    {
        this.surname = surname;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public void setPassword(string password)
    {
        this.password = password;
    }

    public void setPhone(int phone)
    {
        this.phone = phone;
    }

}

