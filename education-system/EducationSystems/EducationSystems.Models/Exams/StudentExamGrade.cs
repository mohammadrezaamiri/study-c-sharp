using EducationSystems.Models.Students;

namespace EducationSystems.Models.Exams;

class StudentExamGrade(Student student)
{
    public Student Student { get; } = student;
    
    private double _grade;
    public double Grade
    {
        get => _grade;
        set
        {
            if (value is > 20 or < 0)
                throw new Exception("grade is invalid");
            Student.CalculateAverage(value);
            _grade = value;
        }
    }
}