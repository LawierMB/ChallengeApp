// Pierwsza klasa

User user1 = new User("Marek", "Password1");
User user2 = new User("Norbert", "Password2");
User user3 = new User("Gosia", "Password3");
User user4 = new User("Damian", "Password4");

Console.WriteLine("Uąytkownik 1: " + user1.Login + " " + user1.Password);
Console.WriteLine("Uąytkownik 3: " + user3.Login + " " + user3.Password);

// przypisanie punktów użytkownikowi user1 przy pomocy metody AddScore()
user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);

// wyświetla podsumowanie punktów user1.ResuldPoint
Console.WriteLine("Zebrane punkty przez użytkownika: " + user1.Login + " to : " + user1.ResultPoint);

class User
{
    // tworzenie nowego kontenera listy "score" do przechowywania punktów
    private List<int> score = new List<int>(); 

    public User(string login, string password)
    {
        this.Login = login;         // pobranie i przypisanie loginu nowego użytkownika
        this.Password = password;   // przypisanie hasła
        
    }

    // propercje (pola) czystrzy sposób odczytania i ew zmian w zmiennych klasy
    public string Login { get; private set; }    // ustawienie Login do odczytu get; i prywatne set; ustawienie
    public string Password { get; private set; } // jak wyżej dla Password

    public int ResultPoint
    {
        get
        {
            // getter zwraca podsumowanie punktów listy "score"
            return this.score.Sum();
        }
    }

    // pierwsza metoda - przykładowo dodawanie punktów dla użytkownika
    public void AddScore(int scorePoint)
    {
        // metoda przy każdym wywołaniu dodaje kolejne punkty do listy
        this.score.Add(scorePoint);
    }
}