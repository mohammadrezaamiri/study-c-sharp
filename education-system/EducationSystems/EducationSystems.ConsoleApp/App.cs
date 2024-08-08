using EducationSystems.ConsoleApp.Menues;
using EducationSystems.Models.EducationSystems;
using static System.Console;

namespace EducationSystems.ConsoleApp;

public static class App
{
    public static void Run()
    {
        var educationSystem = new EducationSystem();

        WriteLine("Hello manager.");
        var workAgain = true;
        while (workAgain)
        {
            ShowMenu();
            var choice = ReadLine();
            switch (choice)
            {
                case "1" : RegisterStudent.Run(educationSystem); break;
                case "2" : RegisterTeacher.Run(educationSystem); break;
                case "3" : RegisterCourse.Run(educationSystem); break;
                case "4" : RegisterExam.Run(educationSystem); break;
                case "5" : AssignExamGradeToStudent.Run(educationSystem); break; // not Implemented
                
                case "6" : ShowStudents.Run(educationSystem); break; // not Implemented
                case "7" : ShowTeachers.Run(educationSystem); break; // not Implemented
                case "8" : ShowCourses.Run(educationSystem); break; // not Implemented 
                case "9" : ShowStudentAverageGrade.Run(educationSystem); break; // not Implemented
                case "10" : ShowTeacherFunctionality.Run(educationSystem); break; // not Implemented
        
                case "11" : workAgain = false; break;
                
                default : WriteLine("invalid choice. try again"); break;
            }   
        }
    }

    private static void ShowMenu()
    {
        Write(@"
Please choose number of action? 

[1]. Register student
[2]. Register teacher
[3]. Register course
[4]. Register exam
[5]. Assign grade to student

[6]. Show students
[7]. Show teachers
[8]. Show courses
[9]. Show student average grade
[10]. Show teacher functionality
[11]. Exit

My Choice is : ");
    }
}