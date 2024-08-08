using EducationSystems.Models.Courses;
using EducationSystems.Models.EducationSystems.Contracts;
using EducationSystems.Models.EducationSystems.Tools;
using EducationSystems.Models.Exams;
using EducationSystems.Models.Students;
using EducationSystems.Models.Teachers;

namespace EducationSystems.Models.EducationSystems;

public class EducationSystem
{
    private readonly List<Exam> _exams = [];
    private readonly List<Course> _courses = [];
    private readonly List<Teacher> _teachers = [];
    private readonly List<Student> _students = [];

    public void RegisterExam(int teacherId, int courseId, DateTime date)
    {
        var teacher = _teachers[teacherId - 1];
        var course = _courses[courseId - 1];
        if (_exams.Any(_ =>
                _.Date.Date == date.Date &&
                _.Teacher.PersonalCode == teacher.PersonalCode &&
                _.Course.Title.ToStandard() == course.Title.ToStandard()))
            return;

        _exams.Add(new Exam(date.Date, teacher, course));
    }

    public void RegisterStudent(string firstName, string lastName, string nationalCode)
    {
        if (_students.Any(_ => _.NationalCode == nationalCode))
            return;
        _students.Add(new Student(firstName, lastName, nationalCode));
    }

    public void RegisterTeacher(string firstName, string lastName, string personalCode)
    {
        if (_teachers.Any(_ => _.PersonalCode == personalCode))
            return;
        _teachers.Add(new Teacher(firstName, lastName, personalCode));
    }

    public void RegisterCourse(string title)
    {
        if (_courses.Any(_ => _.Title.ToStandard() == title.ToStandard()))
            return;
        _courses.Add(new Course(title));
    }

    public void AssignExamGradeToStudent(int studentId, int examId, double grade)
    {
        var student = _students[studentId - 1];
        var exam = _exams[examId - 1];
        exam.AssignGradeToStudent(student, grade);
    }

    public List<ShowStudentDto> ShowStudents(bool doesSortByAverage)
    {
        var students = _students
            .Select((student, index) => new ShowStudentDto
            {
                Id = index + 1,
                FirstName = student.FirstName,
                LastName = student.LastName,
                NationalCode = student.NationalCode,
                Average = student.Average
            }).ToList();
        if (doesSortByAverage)
            students = students.OrderByDescending(_ => _.Average).ToList();
        return students;
    }

    public List<ShowTeacherDto> ShowTeachers()
    {
        return _teachers.Select((teacher, index) => new ShowTeacherDto
        {
            Id = index + 1,
            FirstName = teacher.FirstName,
            LastName = teacher.LastName,
            PersonalCode = teacher.PersonalCode
        }).ToList();
    }
    
    public List<ShowCourseDto> ShowCourses()
    {
        return _courses.Select((course, index) => new ShowCourseDto()
        {
            Id = index + 1,
            Title = course.Title
        }).ToList();
    }

    public List<ShowTeacherFunctionalityDto> ShowTeacherFunctionality(int teacherId)
    {
        var teacher = _teachers[teacherId - 1];
        return teacher.TeacherFunctionalities
            .Select(functionality => new ShowTeacherFunctionalityDto
            {
                CourseId = ShowCourses()
                    .Where(course => functionality.Course.Title.ToStandard() == course.Title.ToStandard())
                    .Select(course => course.Id).First(),
                CourseTitle = functionality.Course.Title,
                Average = functionality.Average,
                StudentsCount = functionality.StudentsCount
            }).ToList();
    }
}