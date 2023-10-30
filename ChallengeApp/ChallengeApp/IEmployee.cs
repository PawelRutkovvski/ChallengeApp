namespace ChallengeApp
{
    // W klasach... JAK... będziemy robić?
    //  W interfejsach... CO... będziemy robić?
    // Interfejs zawiera tylko definicje więc nie zawiera logiki.
    
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        public void AddGrade(float grade);

        public void AddGrade(double grade);

        public void AddGrade(int grade);

        public void AddGrade(char grade);

        public void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
