namespace ChallengeApp
{
    internal interface IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        Statistics GetStatistics();
    }
}
