/// 1.Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych.
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen
/// z zakresu 1-10.
/// 3. NApisz program, który wyszuka pracownika z największą
/// liczbą ocen i wyświetli jego dane oraz wynik.

using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee user1 = new Employee("Wladek", "Jarząbek", "25");
        Employee user2 = new Employee("Maniek", "Bąbel", "34");
        Employee user3 = new Employee("Zenek", "Haubica", "43");

        user1.AddScore(5);
        user1.AddScore(9);
        user1.AddScore(9);
        user1.AddScore(10);
        user1.AddScore(7);

        user2.AddScore(8);
        user2.AddScore(9);
        user2.AddScore(2);
        user2.AddScore(1);
        user2.AddScore(6);

        user3.AddScore(7);
        user3.AddScore(4);
        user3.AddScore(3);
        user3.AddScore(10);
        user3.AddScore(9);


        string maxResult = "";
        int userMaxValue = 0;

        if (user1.PointSum > user2.PointSum && user1.PointSum > user3.PointSum)
        {
            maxResult = user1.Name + " " + user1.Surname + " " + user1.Age;
            userMaxValue = user1.PointSum;
        }
        if (user2.PointSum > user1.PointSum && user2.PointSum > user3.PointSum)
        {
            maxResult = user2.Name + " " + user2.Surname + " " + user2.Age;
            userMaxValue = user2.PointSum;
        }
        if (user3.PointSum > user2.PointSum && user3.PointSum > user1.PointSum)
        {
            maxResult = user3.Name + " " + user3.Surname + " " + user3.Age;
            userMaxValue = user3.PointSum;
        }

        Console.WriteLine("Najwyższa ocena to: " + userMaxValue + " punktów");
        Console.WriteLine("Zdobył ją: " + maxResult);

        Console.ReadLine();
    }
}