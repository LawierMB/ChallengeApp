// Pierwsza klasa
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

User user1 = new User("Marek", "Password1");
User user2 = new User("Norbert", "Password2");
User user3 = new User("Gosia", "Password3");
User user4 = new User("Damian", "Password4");


Console.WriteLine("Uąytkownik 1: " + user1.Login + " " + user1.Password);
Console.WriteLine("Uąytkownik 3: " + user3.Login + " " + user3.Password);

user1.AddScore(5);

class User
{
    private int score; // prywatna zmienna przechowująca punkty użytkownika

    public User(string login, string password)
    {
        this.Login = login;         // pobranie i przypisanie loginu nowego użytkownika
        this.Password = password;   // przypisanie hasła
        this.score = 0;             // ustawienie punktacji dla nowego użytkownika

    }

    // propercje (pola) czystrzy sposób odczytania i ew zmian w zmiennych klasy
    public string Login { get; private set; }    // ustawienie Login do odczytu get; i prywatne set; ustawienie
    public string Password { get; private set; } // jak wyżej dla Password

    // pierwsza metoda - przykładowo dodawanie punktów dla użytkownika
    public void AddScore(int scorepoint)
    {
        this.score += scorepoint;
    }
}