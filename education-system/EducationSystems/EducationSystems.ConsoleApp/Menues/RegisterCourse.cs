using EducationSystems.Models.EducationSystems;
using static System.Console;

namespace EducationSystems.ConsoleApp.Menues;

class RegisterCourse
{
    public static void Run(EducationSystem educationSystem)
    {
        var title = GetTitle();
        educationSystem.RegisterCourse(title);
    }

    private static string GetTitle()
    {
        Write("Enter course title : ");
        
        var title = ReadLine();
        
        if (title != null) return title;
        
        WriteLine("title is invalid. try again");
        
        return GetTitle();
    }
}