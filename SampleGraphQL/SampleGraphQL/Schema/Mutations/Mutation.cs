using SampleGraphQL.Schema.Mutations.Models;

namespace SampleGraphQL.Schema.Mutations
{
    public class Mutation
    {
        public CreateCourseResponse CreateCourse(string title, string description)
        {
            return new CreateCourseResponse()
            {
                Description = description,
                Title = title,
                Id = 1
            };
        }
    }
}
