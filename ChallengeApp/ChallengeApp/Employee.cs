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

    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else throw new Exception("Invalid grade value.");
    }
    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else throw new Exception("String is not float.");
    }
    public void AddGrade(double grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddGrade(result);
        }
    }
    public void AddGrade(int grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddGrade(result);
        }
    }
    public void AddGrade(decimal grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddGrade(result);
        }
    }
    public void AddGrade(long grade)
    {
        if (float.TryParse(grade.ToString(), out float result))
        {
            this.AddGrade(result);
        }
    }
    public void AddGrade(char grade)
    {
        switch(grade)
        {
        case 'A':
                AddGrade(100);
                break;
        case 'B':
                AddGrade(80);
                break;
        case 'C':
                AddGrade(60);
                break;
        case 'D':
                AddGrade(40);
                break;
        case 'E':
                AddGrade(20);
                break;
        default:
                throw new Exception("Wrong Letter. Enter correct one.");
        }
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

        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'E';
                throw new Exception("Wrong Letter.");
        }
        return statistics;
    }
}
