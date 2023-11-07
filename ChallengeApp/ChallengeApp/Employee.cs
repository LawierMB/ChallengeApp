namespace ChallengeApp
{
    public class Employee
    {
                
        private List<float> grades = new List<float>();

        public Employee(string FirstName, string LastName) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
       
        public void AddGrade(int grade)
        {
            // metoda przy każdym wywołaniu dodaje kolejne punkty do listy
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics(); // tworzymy obiekt statistics
            statistics.Average = 0;            // ustawiam wyjściową wartość średniej
            statistics.Max = float.MinValue;   // ustawiam wyjściową wartość Max jako minimalną wartość zmiennej float
            statistics.Min = float.MaxValue;   // dla zmiennej Min przepisuję obecną wartość zmiennej Max

            foreach (var grade in this.grades) 
            {
                // porównuje przychodzącą wartość grade ze statistics.Max i dla statistics.Max wyższą wartość
                statistics.Max = Math.Max(statistics.Max, grade);
                // porównuje przychodzącą wartość grade ze statistics.Min i dla statistics.Min mniejszą wartość
                statistics.Min = Math.Min(statistics.Min, grade);
                // sumuje wartośći grade w zmiennej statistics.Average
                statistics.Average += grade;
            }
            // statistics.Average = statistics.Average / this.grades.Count; // inna wersja wyliczenia średniej 
            statistics.Average /= this.grades.Count;
            

            return statistics;
        }
    }
}
