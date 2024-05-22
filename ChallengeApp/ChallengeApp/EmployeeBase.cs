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

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
        
    }
}
