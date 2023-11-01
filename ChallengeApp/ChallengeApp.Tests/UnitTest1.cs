namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange - dane wejœciowe
            var user = new User("Marek", "Password");
            user.AddScore(5);
            user.AddScore(10);

            // act - akcja 
            var result = user.ResultPoint;

            // assert - badanie wyniku testu
            Assert.AreEqual(15, result);
        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()
        {
            // arrange - dane wejœciowe
            var user = new User("Marek", "Password");
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(-5);

            // act - akcja 
            var result = user.ResultPoint;

            // assert - badanie wyniku testu
            Assert.AreEqual(10, result);

        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResultZero()
        {
            // arrange - dane wejœciowe
            var user = new User("Marek", "Password");
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(-15);

            // act - akcja 
            var result = user.ResultPoint;

            // assert - badanie wyniku testu
            Assert.AreEqual(0, result);           
        }
    }
}