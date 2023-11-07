namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenISubmitThreeRatingsIWillReceiveTheExpectedAverage()
        {
            // arrange 
            var employee = new Employee("Artem", "Dziarski");

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
            var employee = new Employee("Artem", "Dziarski");

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
            var employee = new Employee("Artem", "Dziarski");

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
            var employee = new Employee("Artem", "Dziarski");

            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(9);

            // act 
            var statistic = employee.GetStatistics();

            // assert 
            Assert.AreEqual(9, Math.Round(Math.Abs(statistic.Max), 2));
        }
    }
}
