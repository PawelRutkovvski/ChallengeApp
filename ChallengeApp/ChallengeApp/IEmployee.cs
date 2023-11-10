namespace ChallengeApp
{
    // W klasach... JAK... będziemy robić?
    //  W interfejsach... CO... będziemy robić?
    // Interfejs zawiera tylko definicje, więc nie zawiera logiki.
    
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
