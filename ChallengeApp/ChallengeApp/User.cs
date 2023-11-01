
namespace ChallengeApp
{
    public class User
    {
        // tworzenie nowego kontenera listy "score" do przechowywania punktów
        private List<int> score = new List<int>();


        public User(string login)
        {
            this.Login = login;         // pobranie i przypisanie loginu nowego użytkownika
        }

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
}
