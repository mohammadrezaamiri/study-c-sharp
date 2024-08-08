namespace EducationSystems;

public class EducationSystem
{
    private readonly EducationSystemArchive _archive = new();
    public IArchive Archive => _archive;

    public void AddStudent(string name)
    {
        _archive.Students.Add(new Student{Name = name});
    }
}

public interface IArchive
{
    List<ShowStudentDto> ShowStudents();
}

public class ShowStudentDto
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
}

internal class EducationSystemArchive : IArchive
{
    internal List<Student> Students { get; set; }
    
    public List<ShowStudentDto> ShowStudents()
    {
        throw new NotImplementedException();
    }
}

internal class Student
{
    public string Name { get; set; }
} 