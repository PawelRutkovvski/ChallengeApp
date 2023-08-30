namespace ChallengeApp;

public class Employee
{
    private List<float> grades = new List<float>();
    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    public string Name { get; set; }
    public string Surname { get; set; }

    public void AddScore(float grade)
    {
        if (grade <= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else Console.WriteLine("invalid grade");
    }
    public void AddScore(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddScore(result);
        }
        else Console.WriteLine("String is not float.");
    }
    public void AddScore(double grade)
    {
        var fromDoubleValue = (float)grade;
        this.AddScore(fromDoubleValue);
    }
    public void AddScore(int grade)
    {
        float fromIntValue = grade;
        this.AddScore(fromIntValue);
    }
    public void AddScore(decimal grade)
    {
        var fromDecimalValue = (decimal)grade;
        this.AddScore(fromDecimalValue);
    }
    public void AddScore(long grade)
    {
        var fromLongValue = (long)grade;
        this.AddScore(fromLongValue);
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();

        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        statistics.Average /= this.grades.Count;

        return statistics;
    }
}
