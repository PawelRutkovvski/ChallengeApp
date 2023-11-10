 namespace ChallengeApp.Tests
{
    public class WhenAddGrade_ShouldGetMinMax
    {
        [Test]
        public void WhenCollectGrades_GetCorrectMin()
        {
            //arrange
            var employee = new Employee("Pawel", "Rutkowski", 'M');

            employee.AddGrade(10);
            employee.AddGrade(98);
            employee.AddGrade(15);

            //act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(10, statistics.Min);
                      
        }

        [Test]
        public void WhenCollectGrades_GetCorrectMax()
        {
            //arrange
            var employee = new Employee("Pawel", "Rutkowski", 'M');

            employee.AddGrade(16);
            employee.AddGrade(26);
            employee.AddGrade(86);

            //act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.AreEqual(86, statistics.Max);

        }
    }
}
