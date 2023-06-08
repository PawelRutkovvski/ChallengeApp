namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectPoints_ShouldCorrectSum()
        {
            //arrange
            var user1 = new Employee("Wlad", "Palownik", "136");
            var user2 = new Employee("Ivan", "Grozny", "99");

            user1.AddScore(5);
            user1.AddScore(6);
            user2.AddScore(-4);
            user2.AddScore(-6);

            //act
            var result1 = user1.PointSum;
            var result2 = user2.PointSum;

            //Assert
            Assert.AreEqual(11, result1);
            Assert.AreEqual(-10, result2);
        }
    }
}