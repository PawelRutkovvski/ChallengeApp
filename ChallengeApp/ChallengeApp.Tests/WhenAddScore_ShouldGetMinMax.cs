 namespace ChallengeApp.Tests
{
    public class WhenAddGrade_ShouldGetMinMax
    {
        [Test]
        public void WhenCollectGrades_GetCorrectMin()
        {
            //arrange
            var employee = new Employee("Pawel", "Rutkowski", 'M');

            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(8);

            //act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(2, statistics.Min);
                      
        }

        [Test]
        public void WhenCollectGrades_GetCorrectMax()
        {
            //arrange
            var employee = new Employee("Pawel", "Rutkowski", 'M');

            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(8);

            //act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(8, statistics.Max);

        }
    }
}
