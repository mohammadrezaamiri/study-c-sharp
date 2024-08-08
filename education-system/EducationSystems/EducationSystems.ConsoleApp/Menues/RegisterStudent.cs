using EducationSystems.Models.EducationSystems;
using static System.Console;

namespace EducationSystems.ConsoleApp.Menues;

class RegisterStudent
{
    public static void Run(EducationSystem educationSystem)
    {
        var firstName = GetUserInput("first name");
        var lastName = GetUserInput("last name");
        var nationalCode = GetUserInput("national code");
        
        educationSystem.RegisterStudent(firstName, lastName, nationalCode);
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