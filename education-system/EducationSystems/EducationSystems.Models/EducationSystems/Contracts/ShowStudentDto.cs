namespace EducationSystems.Models.EducationSystems.Contracts;

public record ShowStudentDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public double Average { get; set; }
}