using FakeApp.API;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/message", (Message message) =>
{
    Console.WriteLine(message.content);
    Console.WriteLine($"{message.metadata.authorName} - {message.metadata.creationTime}");
    return Results.Ok();
});

app.Run("http://localhost:5000");
