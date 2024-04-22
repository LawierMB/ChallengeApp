﻿namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Supervisor(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void AddGrade(float grade)
        {
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
            switch(grade)
            {
                case "6":
                    {
                        this.AddGrade(100);
                    }break;
                case "6-":
                case "-6":
                    {
                        this.AddGrade(95);
                    }
                    break;
                case "+6":
                case "6+":
                    {
                        this.AddGrade(100);
                    }
                    break;
                case "5":
                    {
                        this.AddGrade(80);
                    }
                    break;
                case "5-":
                case "-5":
                    {
                        this.AddGrade(75);
                    }
                    break;
                case "+5":
                case "5+":
                    {
                        this.AddGrade(85);
                    }
                    break;
                case "4":
                    {
                        this.AddGrade(60);
                    }
                    break;
                case "-4":
                case "4-":
                    {
                        this.AddGrade(55);
                    }
                    break;
                case "+4":
                case "4+":
                    {
                        this.AddGrade(65);
                    }
                    break;
                case "3":
                    {
                        this.AddGrade(30);
                    }
                    break;
                case "3-":
                case "-3":
                    {
                        this.AddGrade(25);
                    }
                    break;
                case "+3":
                case "3+":
                    {
                        this.AddGrade(35);
                    }
                    break;
                case "2":
                    {
                        this.AddGrade(20);
                    }
                    break;
                case "2-":
                case "-2":
                    {
                        this.AddGrade(15);
                    }
                    break;
                case "+2":
                case "2+":
                    {
                        this.AddGrade(25);
                    }
                    break;
                default:
                    {
                        this.AddGrade(0);
                    }break;
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
        
    }
}
