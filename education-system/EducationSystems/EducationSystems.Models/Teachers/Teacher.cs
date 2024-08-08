using EducationSystems.Models.Courses;
using EducationSystems.Models.EducationSystems.Tools;

namespace EducationSystems.Models.Teachers;

class Teacher(string firstName, string lastName, string personalCode)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public string PersonalCode { get; } = personalCode;
    public List<TeacherFunctionality> TeacherFunctionalities { get; } = [];

    public void CalculateAverage(Course course, double grade)
    {
        var functionality = 
            TeacherFunctionalities.SingleOrDefault(_ =>
                _.Course.Title.ToStandard() == course.Title.ToStandard());

        if (functionality == null)
            functionality = AddFunctionality(course);

        functionality.ApplyGradeToAverage(grade);
    }

    private TeacherFunctionality AddFunctionality(Course course)
    {
        var functionality = new TeacherFunctionality(course);
        TeacherFunctionalities.Add(functionality);
        return functionality;
    }
}