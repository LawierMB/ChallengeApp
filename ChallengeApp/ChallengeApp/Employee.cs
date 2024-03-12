namespace ChallengeApp
{
    public class Employee : IEmployee
    {       
        private List<float> grades = new List<float>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Sex { get; private set; }
        public string Age { get; private set; }
        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public Employee(string FirstName, string LastName, string Sex)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Sex = Sex;
        }
        public Employee(string FirstName, string LastName, string Sex, string Age)
        {
            this.Age = Age;
        }
        public void AddGrade(float grade)
        {
            // metoda przy każdym wywołaniu dodaje kolejne punkty do listy
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($" {grade} Inwalid grade values !");
            }
        }
        public void AddGrade(string grade)
        {
            // sprawdza czy grade da się sparsować do float jeśli tak to przypisuje do result
            
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception($"This string: {grade} is not float !");
            }
        }
        public void AddGrade(int grade)
        {
            var result = (float)grade;
            this.AddGrade(result);  
        }
        public void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                var result = (double)grade;
                this.AddGrade(result);
            }
            else
            {
                throw new Exception($"variable range exceeded: {grade} is not float !");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter !");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics(); 
            statistics.Average = 0;            
            statistics.Max = float.MinValue;   
            statistics.Min = float.MaxValue;   

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            // dla wartości średniej Average przypisujemy symbol literowy w zależności od zakresu średniej
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }      
        
    }
}
