namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();

        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value.");
            }
        }

        public override void AddGrade(double grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }

        public override void AddGrade(int grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }

        public override void AddGrade(char grade)
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
                    throw new Exception("Wrong Letter. Enter correct one.");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float.");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

         return statistics;
        }
    }
}
