using EducationSystems.Models.Courses;

namespace EducationSystems.Models.Teachers;

class TeacherFunctionality(Course course)
{
    public Course Course { get; } = course;
    public int StudentsCount { get; private set; }
    public double Average { get; private set; }

    public void ApplyGradeToAverage(double grade)
    {
        StudentsCount += 1;
        Average = (Average + grade) / StudentsCount;
    }
}