namespace StudentEnrollment
{
    public enum CourseName
    {
        AIML, Dotnet, Java
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }
        public string? CourseName { get; set; }
    }
}