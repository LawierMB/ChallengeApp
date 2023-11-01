namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetFloatVariablesToReturnDifferentValues()
        {
            // arrange 
            float numberF1 = 25.30f;
            float numberF2 = 17.11f;

            // act 

            // assert 
            Assert.AreNotEqual(numberF1, numberF2);
        }
        [Test]
        public void CheckTheComparisonOfTwoStrings()
        {
            // arrange 
            string text1 = "Marek";
            string text2 = "Marek";

            // act 


            // assert 
            Assert.AreEqual(text1, text2);
        }
        [Test]
        public void CheckTheComparisonOfTwoValues()
        {
            // arrange 
            int number1 = 1;
            int number2 = 2;

            // act

            // assert 
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObiects()
        {
            // arrange 
            var user1 = new User("Marek");
            var user2 = new User("Andrzej");

            // act  
            
            // assert 
            Assert.AreNotEqual(user1.Login, user2.Login);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
