namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenISubmitThreeRatingsIWillReceiveTheExpectedAverage()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");

            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(6);

            // act 
            var statistic = employee.GetStatistics();
            
            // assert 
            Assert.AreEqual(4.33, Math.Round(Math.Abs(statistic.Average), 2));
        }

        [Test]
        public void WhenISubmitThreeDecimalRatingsReceiveTheExpectedAverage()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");

            employee.AddGrade(3.4f);
            employee.AddGrade(4.3f);
            employee.AddGrade(6.0f);

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreEqual(4.57, Math.Round(Math.Abs(statistic.Average), 2));
        }
        [Test]
        public void WhenISubmittedThreeGradesIDidntReceiveTheExpectedAverage()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");

            employee.AddGrade(8);
            employee.AddGrade(3);
            employee.AddGrade(5);

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreNotEqual(4.57, Math.Round(Math.Abs(statistic.Average), 2));
        }

        [Test]
        public void WhenISubmittedThreeRatingsIWillReceivetheExpectedMaxValue()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");

            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(9);

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreEqual(9, Math.Round(Math.Abs(statistic.Max), 2));
        }
        [Test]
        public void TheAverageGradeReachesTheBRange()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");

            employee.AddGrade('C');
            employee.AddGrade(70);
            employee.AddGrade(85);
            employee.AddGrade(40);
            employee.AddGrade(82);

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreEqual('B', statistic.AverageLetter);
            Assert.AreEqual(85, Math.Round(Math.Abs(statistic.Max), 2));
            Assert.AreEqual(40, Math.Round(Math.Abs(statistic.Min), 2));
        }
        [Test]
        public void TheAverageGradeReachesTheCRange()
        {
            // arrange 
            var employee = new EmployeeInMemory("Artem", "Dziarski", "M");
            
            employee.AddGrade('d');
            employee.AddGrade('d');
            employee.AddGrade('c');
            employee.AddGrade('b');

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreEqual('C', statistic.AverageLetter);
            Assert.AreEqual(80, Math.Round(Math.Abs(statistic.Max), 2));
            Assert.AreEqual(40, Math.Round(Math.Abs(statistic.Min), 2));
        }
        //[Test]
        //public void AddingAManagerWithGrades()
        //{
        //    // arrange
        //    var supervisor = new Supervisor("Antoni", "Bombel");

        //    supervisor.AddGrade(5);
        //    supervisor.AddGrade("-2");
        //    supervisor.AddGrade('b');

        //    // act
        //    var statistics = supervisor.GetStatistics();

        //    // assert
        //    Assert.AreEqual(58.32, Math.Round(Math.Abs(statistics.Average), 2));
        //    Assert.AreEqual(80, Math.Round(Math.Abs(statistics.Max), 2));
        //    Assert.AreEqual(15, Math.Round(Math.Abs(statistics.Min), 2));

        //}
    }
}
