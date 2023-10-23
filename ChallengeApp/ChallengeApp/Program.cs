// Pierwsza klasa
User user1 = new User("Marek", "Marek", "Password");
User user2 = new User("Norbert");
User user3 = new User("Gosia");
User user4 = new User("Damian");
User user5 = new User();

//user1.login = "Marek";        // bezpośrednie przypisanie do obiektu
//user1.password = "Password";  // gdy zmienne są publiczne

class User
{
    private string login;
    private string password;
    private string name;

    // pierwszy konstruktor
    public User(string login) 
         {
           this.login = login;
         }
    // kolejne konstruktory może być ich wiele
    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";   
    }

    public User(string login, string password, string name )
    {
        this.login = login;
        this.password = password;
        this.name = name;
    }


}