namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestString()
        {
            string text1 = "Tadek";
            string text2 = "Edek";
         
            Assert.AreNotEqual(text1, text2);
        }
        [Test]
        public void TestWartosciowy()
        {
            int number1 = 1;
            int number2 = 3;
            float number3 = 3;
            float number4 = 4;
          
            Assert.AreNotEqual(number1, number2);
            Assert.AreNotEqual(number1, number3);
        }
        [Test]
        public void TestReferencyjny()
        {
            var user1 = GetUser("Wlad", "Palownik", "309");
            var user2 = GetUser("Ivan", "Grozny", "164");
          
            Assert.AreNotEqual(user1, user2);
        }


        private Employee GetUser(string name, string lastname, string age)
        {
            return new Employee(name, lastname, age);
        }
    }
}
