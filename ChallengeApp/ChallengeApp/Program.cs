/// 1.Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych.
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen
/// z zakresu 1-10.
/// 3. NApisz program, który wyszuka pracownika z największą
/// liczbą ocen i wyświetli jego dane oraz wynik.

using ChallengeApp;

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

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userMaxValue = null;

foreach(var user in users)
{
    if(user1.Result > maxResult)
    {
        userMaxValue = user1;
        maxResult = user1.Result;
    }
    else if(user2.Result > maxResult)
    {
        userMaxValue = user2;
        maxResult = user2.Result;   
    }
    else if(user3.Result > maxResult)
    {
        userMaxValue = user3;
        maxResult = user3.Result;
    }
}

Console.WriteLine("Najwyższa ocena to: " + maxResult + " punktów"); 
Console.WriteLine("Zdobył ją: " + userMaxValue.Name + " " + userMaxValue.Surname + " " + userMaxValue.Age + " lat");