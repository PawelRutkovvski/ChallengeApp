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
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else Console.WriteLine("invalid grade value");
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
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddScore(result);
        }
    }
    public void AddScore(int grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddScore(result);
        }
    }
    public void AddScore(decimal grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddScore(result);
        }
    }
    public void AddScore(long grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddScore(result);
        }
    }
    public Statistics GetStatisticsWithFor()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        for (var i = 0; i < grades.Count; i++)
        {
            statistics.Max = Math.Max(statistics.Max, grades[i]);
            statistics.Min = Math.Min(statistics.Min, grades[i]);
            statistics.Average += grades[i];
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWithForEach()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach(var grade in grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWithWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        while(index < this.grades.Count)
        {
            statistics.Max = Math.Max(statistics.Max, grades[index]);
            statistics.Min = Math.Min(statistics.Min, grades[index]);
            statistics.Average += grades[index];
            index++;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }
    public Statistics GetStatisticsWithDoWhile()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;
        var index = 0;

        do {
            statistics.Max = Math.Max(statistics.Max, grades[index]);
            statistics.Min = Math.Min(statistics.Min, grades[index]);
            statistics.Average += grades[index];
            index++;
        } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
        return statistics;
    }
}
