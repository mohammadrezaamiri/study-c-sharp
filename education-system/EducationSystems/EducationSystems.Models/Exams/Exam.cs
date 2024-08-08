using EducationSystems.Models.Courses;
using EducationSystems.Models.Students;
using EducationSystems.Models.Teachers;

namespace EducationSystems.Models.Exams;

class Exam(DateTime date, Teacher teacher, Course course)
{
    private DateTime _date;
    public DateTime Date
    {
        get => _date;
        set
        {
            if (value > DateTime.Now) throw new Exception("exam date is invalid");
            _date = date;
        }
    }

    public Teacher Teacher { get; } = teacher;
    public Course Course { get; } = course;
    public List<StudentExamGrade> StudentsExamGrade { get; } = [];

    public void AssignGradeToStudent(Student student, double grade)
    {
        if (StudentsExamGrade.Any(_ => _.Student.NationalCode == student.NationalCode))
            throw new Exception("Student grade already assigned before");
        StudentsExamGrade.Add(new StudentExamGrade(student) { Grade = grade });
        teacher.CalculateAverage(Course, grade);
    }
}