// See https://aka.ms/new-console-template for more information

using EducationSystems;

Console.WriteLine("Hello, World!");

var educationSystem = new EducationSystem();
educationSystem.AddStudent("ali");
educationSystem.Archive.ShowStudents();
