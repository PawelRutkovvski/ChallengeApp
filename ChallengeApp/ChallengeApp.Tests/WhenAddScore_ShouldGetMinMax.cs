namespace ChallengeApp.Tests
{
    public class WhenAddScore_ShouldGetMinMax
    {
        [Test]
        public void WhenCollectGrades_GetCorrectMinMax()
        {
            //arrange
            var employee = new Employee("Pawel", "Tenet");

            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(8);

            //act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            
        }
    }
}
