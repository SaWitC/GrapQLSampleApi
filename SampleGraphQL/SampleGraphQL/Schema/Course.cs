namespace SampleGraphQL.Schema
{
    public class Course
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Student>? Students { get; set; }

    }
}
