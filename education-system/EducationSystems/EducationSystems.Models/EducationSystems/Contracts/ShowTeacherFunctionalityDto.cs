namespace EducationSystems.Models.EducationSystems.Contracts;

public record ShowTeacherFunctionalityDto
{
    public int CourseId { get; set; }
    public string CourseTitle { get; set; }
    public int StudentsCount { get; set; }
    public double Average { get; set; }
}