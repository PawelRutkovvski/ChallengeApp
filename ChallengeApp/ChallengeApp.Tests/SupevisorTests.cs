namespace ChallengeApp.Tests
{
    public class SupevisorTests
    {
        [Test]
        public void SupervisorGradeMinTest()
        {

            var emp = new Supervisor("Ivan", "CoMaWszystko", 'M');

            emp.AddGrade("6");
            emp.AddGrade("4+");
            emp.AddGrade("-2");

            var statistics = emp.GetStatistics();

            Assert.AreEqual(15, statistics.Min);

        }
    }
}
