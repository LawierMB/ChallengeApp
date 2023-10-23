namespace ChallengeApp
{
    public class Employee
    {
        // tworzenie nowego kontenera listy "score" do przechowywania punktów
        private List<int> score = new List<int>();

        public Employee(string FirstName, string LastName, int Age) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public int ResultPoint
        {
            get
            {
                // getter zwraca podsumowanie punktów listy "score"
                return this.score.Sum();
            }
        }

        public void AddScore(int scorePoint)
        {
            // metoda przy każdym wywołaniu dodaje kolejne punkty do listy
            this.score.Add(scorePoint);
        }
    }
}
