namespace EducationSystems.Models.EducationSystems.Tools;

public static class Standard
{
    public static string ToStandard(this string value) 
        => value.Replace(" ", "").ToLower();
}