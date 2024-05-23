namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public EmployeeBase(string FirstName, string LastName)

        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public abstract void AddGrade(float grade);
        public void AddGrade(string grade)
        {
            // sprawdza czy grade da się sparsować do float jeśli tak to przypisuje do result

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGrade(charResult);
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
        public  void AddGrade(double grade)
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
        public abstract Statistics GetStatistics();
        
    }
}
