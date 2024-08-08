using System.Globalization;
using EducationSystems.Models.EducationSystems;
using static System.Console;

namespace EducationSystems.ConsoleApp.Menues;

public static class RegisterExam
{
    public static void Run(EducationSystem educationSystem)
    {
        var teacherId = GetTeacherId(educationSystem);
        var courseId = GetCourseId(educationSystem);
        var date = GetDate();
        educationSystem.RegisterExam(teacherId, courseId, date);
    }

    private static DateTime GetDate()
    {
        Write(
            @"
Date should not be in future.
Date format should be year-month-day.
Date should be gregorian.

Enter date of exam : ");
        var dateInput = ReadLine();
        if (dateInput != null &&
            DateTime.TryParseExact(
                dateInput,
                "yyyy-mm-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime date))
            return date;
        WriteLine("Invalid date. Try again");
        return GetDate();
    }

    private static int GetCourseId(EducationSystem educationSystem)
    {
        WriteLine("All courses are :");
        
        educationSystem.ShowCourses()
            .ForEach(course => WriteLine($"[{course.Id}]. {course.Title}"));
        
        Write("Choose course number : ");
        
        var choice = ReadLine();
        
        var courseId = 0;
        
        if ((choice != null || int.TryParse(choice, out courseId)) &&
            educationSystem.ShowCourses().Any(course => course.Id == courseId))
            return courseId;
        
        WriteLine("Course number is invalid. Try again");
        
        return GetCourseId(educationSystem);
    }

    private static int GetTeacherId(EducationSystem educationSystem)
    {
        WriteLine("All teachers are :");
        
        educationSystem.ShowTeachers()
            .ForEach(teacher => WriteLine(
                $"[{teacher.Id}]. {teacher.FirstName} {teacher.LastName} {teacher.PersonalCode}"));
        
        Write("Choose teacher number : ");
        
        var choice = ReadLine();
        
        var teacherId = 0;
        
        if ((choice != null || int.TryParse(choice, out teacherId)) &&
            educationSystem.ShowTeachers().Any(teacher => teacher.Id == teacherId))
            return teacherId;
        
        WriteLine("Teacher number is invalid. Try again");
        
        return GetTeacherId(educationSystem);
    }
}