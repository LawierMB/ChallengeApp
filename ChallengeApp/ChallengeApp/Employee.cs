using System.Diagnostics;

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
       
        public void AddGrade(float grade)
        {
            // metoda przy każdym wywołaniu dodaje kolejne punkty do listy
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine(grade +" Inwalid grade values !!");
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
                Console.WriteLine("This string: " + grade + " is not float !");
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
                Console.WriteLine("variable range exceeded: " + grade + " is not float !");
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


            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics(); // tworzymy obiekt statistics
            statistics.Average = 0;            // ustawiam wyjściową wartość średniej
            statistics.Max = float.MinValue;   // ustawiam wyjściową wartość Max jako minimalną wartość zmiennej float
            statistics.Min = float.MaxValue;   // dla zmiennej Min przepisuję obecną wartość zmiennej Max

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;   
            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics(); 
            statistics.Average = 0;            
            statistics.Max = float.MinValue;   
            statistics.Min = float.MaxValue;   

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } 

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics(); 
            statistics.Average = 0;            
            statistics.Max = float.MinValue;   
            statistics.Min = float.MaxValue;   

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
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


            return statistics;
        }
    }
}
