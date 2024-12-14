namespace SampleGraphQL.Schema.Queries
{
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public List<Course>? Courses { get; set; }

    }
}
