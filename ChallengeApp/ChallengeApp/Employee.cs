namespace ChallengeApp;

public class Employee
{
    private List<int> points = new List<int>();
    public Employee(string name, string surname, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Age { get; set; }
    public int PointSum
    {
        get
        {
            return this.points.Sum();
        }
    }
    public void AddScore(int point)
    {
        this.points.Add(point);
    }
}
