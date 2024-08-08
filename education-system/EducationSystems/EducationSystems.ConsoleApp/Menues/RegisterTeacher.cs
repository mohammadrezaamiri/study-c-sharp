using EducationSystems.Models.EducationSystems;
using static System.Console;

namespace EducationSystems.ConsoleApp.Menues;

class RegisterTeacher
{
    public static void Run(EducationSystem educationSystem)
    {
        var firstName = GetUserInput("first name");
        var lastName = GetUserInput("last name");
        var personalCode = GetUserInput("personal code");
        
        educationSystem.RegisterTeacher(firstName, lastName, personalCode);
    }

    private static string GetUserInput(string inputName)
    {
        Write($"Enter {inputName} : ");
        
        var input = ReadLine();
        
        if (input != null) return input;
        
        WriteLine($"{inputName} is invalid. try again");
        
        return GetUserInput(inputName);
    }
}