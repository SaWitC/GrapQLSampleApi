using Bogus;

namespace SampleGraphQL.Schema.Queries
{
    public class Query
    {
        public List<Student> GetStudents()
        {
            var faker = new Faker<Student>();
            var schema = faker.RuleSet("test", (settings) =>
            {
                settings.RuleFor(u => u.FirstName, (f, u) => f.Person.FirstName);
                settings.RuleFor(u => u.LastName, (f, u) => f.Person.LastName);
                settings.RuleFor(u => u.Phone, (f, u) => f.Person.Phone);
                settings.RuleFor(u => u.Email, (f, u) => f.Person.Email);
            });
            return faker.Generate(4, "test,default");
        }
    }
}
