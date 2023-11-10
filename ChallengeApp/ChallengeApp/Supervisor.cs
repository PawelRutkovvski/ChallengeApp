namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new();

        public Supervisor(string name, string surname, char gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Gender { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else throw new Exception("Invalid Grade Value");
        }

        public void AddGrade(int grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }

        public void AddGrade(double grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-" or "-6":
                    AddGrade(95);
                    break;
                case "5+" or "+5":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5-" or "-5":
                    AddGrade(75);
                    break;
                case "4+" or "+4":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4-" or "-4":
                    AddGrade(55);
                    break;
                case "3+" or "+3":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3-" or "-3":
                    AddGrade(35);
                    break;
                case "2+" or "+2":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2-" or "-2":
                    AddGrade(15);
                    break;
                case "1+" or "+1":
                    AddGrade(5);
                    break;
                case "1":
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    AddGrade(100);
                    break;
                case 'B' or 'b':
                    AddGrade(80);
                    break;
                case 'C' or 'c':
                    AddGrade(60);
                    break;
                case 'D' or 'd':
                    AddGrade(40);
                    break;
                case 'E' or 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
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
}