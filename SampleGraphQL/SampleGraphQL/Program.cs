using SampleGraphQL.Schema.Mutations;
using SampleGraphQL.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");

app.Run();
