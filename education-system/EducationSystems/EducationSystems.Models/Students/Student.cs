namespace EducationSystems.Models.Students;

class Student(string firstName, string lastName, string nationalCode)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public string NationalCode { get; } = nationalCode;
    public double Average { get; private set; }
    public int ExamCount { get; private set; }

    public void CalculateAverage(double grade)
    {
        ExamCount += 1;
        Average = (Average + grade) / ExamCount;
    }
}