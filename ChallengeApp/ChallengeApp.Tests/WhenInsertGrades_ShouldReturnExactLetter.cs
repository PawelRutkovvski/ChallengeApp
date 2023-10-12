namespace ChallengeApp.Tests
{
    public class WhenInsertGrades_ShouldReturnExactLetter
    {
        [Test]
        public void ReturnExactLetterC_AfterInsertGrades()
        {
            var employee = new Employee("Paweł", "Rutkowski");
            employee.AddGrade(24);
            employee.AddGrade(64);
            employee.AddGrade(82);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void ReturnExactLetterA_AfterInsertGrades()
        {
            var employee = new Employee("Paweł", "Rutkowski");
            employee.AddGrade(81);
            employee.AddGrade(77);
            employee.AddGrade(98);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}
