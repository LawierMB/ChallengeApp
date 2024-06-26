﻿namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public string Sex { get; private set; }
        public string Age { get; private set; }
        public EmployeeInMemory(string FirstName, string LastName) 
            : base(FirstName, LastName)
        {
        }
        public EmployeeInMemory(string FirstName, string LastName, string Sex)
            : base(FirstName, LastName)
        {  
            this.Sex = Sex;
        }
        public EmployeeInMemory(string FirstName, string LastName, string Sex, string Age)
            : base(FirstName, LastName)
        {
            this.Age = Age;
        }
        public override void AddGrade(float grade)
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
        public override Statistics GetStatistics()
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
